using System;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;
using Unity.Transforms;
using UnityEngine;

namespace Example.Danmaku
{
    public class BulletSpawnSystem : SystemBase
    {

        EndSimulationEntityCommandBufferSystem _ecb;
        
        //TODO: We need to profile this thoroughly as we don't know when
        //a system is stopped, or suspended.
        public BlobAssetReference<BulletPrefabBlobAsset> bulletDataBlob;
        public BlobAssetReference<PatternBlobAsset> patternDataBlob;
        protected override void OnStopRunning()
        {
            bulletDataBlob.Dispose();
            patternDataBlob.Dispose();
        }
        protected override void OnCreate()
        {
            _ecb = World.GetOrCreateSystem<EndSimulationEntityCommandBufferSystem>();
        }
        protected override void OnUpdate()
        {
            var delta = Time.DeltaTime;

            Entities
                .WithNone<Prefab>()
                .ForEach((int entityInQueryIndex, ref GapData gap) =>
                {
                    if (gap.countdown <= 0)
                    {
                        gap.active = true;
                        gap.countdown = gap.timeGap;
                    }
                    else
                    {
                        gap.countdown -= delta;
                        gap.active = false;
                    }
                }).Run();


            var ecb = _ecb.CreateCommandBuffer().AsParallelWriter();

            //Set global blob referrences as locals.
            var pattern = patternDataBlob;
            var bullet = bulletDataBlob;

            //
            Entities
                .WithNone<Prefab>() 
                .ForEach((int entityInQueryIndex, in Rotation rotation, in Translation translation, in PatternBlobIndexData patternData, in BulletBlobIndexData bulletData, in GapData gap) =>
                {
                    if (gap.active)
                    {
                        //Must be ref so not to work in a copy set.
                        ref var patternBlob = ref pattern.Value;
                        ref var bulletBlob = ref bullet.Value;
                        
                        var minRot = patternBlob.patternDataArray[patternData.index].minRotation;

                        var bulletDenominator = minRot <= 0 ? patternBlob.patternDataArray[patternData.index].bulletNumber : patternBlob.patternDataArray[patternData.index].bulletNumber - 1;

                        var degreeGap = (patternBlob.patternDataArray[patternData.index].maxRotation - minRot) / bulletDenominator;

                        for (int i = 0; i < patternBlob.patternDataArray[patternData.index].bulletNumber; i++)
                        {
                            Entity spawnedEntity = ecb.Instantiate(entityInQueryIndex, bulletBlob.bulletPrefab[bulletData.index]);

                            //Set Speed
                            ecb.SetComponent(entityInQueryIndex, spawnedEntity, new BulletSpeedData
                            {
                                Value = patternBlob.patternDataArray[patternData.index].speed
                            });
                            //TODO: add target speed.
                            //initial velocity.
                            //acceleration


                            //LifeTime
                            ecb.SetComponent(entityInQueryIndex, spawnedEntity, new TimeToLiveData
                            {
                                lifetime = patternBlob.patternDataArray[patternData.index].lifetime
                            });

                            //DamageValue
                            ecb.SetComponent(entityInQueryIndex, spawnedEntity, new HealthData
                            {
                                value = patternBlob.patternDataArray[patternData.index].damage
                            });

                            float theta = (degreeGap * i) + minRot;
                            while (theta > 360)
                            {
                                theta -= 360;
                            }
                            var x = patternBlob.patternDataArray[patternData.index].innerCircleSize * math.cos(math.radians(theta == 90 || theta == 270 ? 0 : theta));
                            
                            var y = patternBlob.patternDataArray[patternData.index].innerCircleSize * math.sin(math.radians(theta == 180 || theta == 360 ? 0 : theta));

                            var point = math.float3(x, y, 0);
                            
                            var displace =math.float3(patternBlob.patternDataArray[patternData.index].distanceFromSpawn, 0.001f);

                            //Spawn Point
                            ecb.SetComponent(entityInQueryIndex, spawnedEntity, new Translation
                            {
                                Value = translation.Value + math.mul(rotation.Value,displace + point)
                            });

                            //Direction of the Bullet
                            ecb.SetComponent(entityInQueryIndex, spawnedEntity, new Rotation
                            {
                                Value = math.mul(rotation.Value, quaternion.Euler(0, 0, math.radians(patternBlob.patternDataArray[patternData.index].minRotation + (i * degreeGap))))
                            });
                        }
                    }
                }).ScheduleParallel();

            _ecb.AddJobHandleForProducer(this.Dependency);
        }
    }
}
