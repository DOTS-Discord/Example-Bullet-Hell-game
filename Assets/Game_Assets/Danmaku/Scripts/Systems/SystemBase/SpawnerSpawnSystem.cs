using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Collections;
using UnityEngine;

namespace Example.Danmaku
{
    [UpdateInGroup(typeof(InitializationSystemGroup))]
    public class SpawnerSpawnSystem : SystemBase
    {
        BeginSimulationEntityCommandBufferSystem _ecb;
        int stuff = 0;
        EntityQuery q_spawners;
        protected override void OnCreate()
        {
            _ecb = World.GetOrCreateSystem<BeginSimulationEntityCommandBufferSystem>();
            q_spawners = GetEntityQuery(
                    new EntityQueryDesc 
                    {
                        All = new ComponentType[] { typeof(SpawnerTag)},
                        None = new ComponentType[] { typeof(Prefab)}
                    }
                );
        }
        protected override void OnUpdate()
        {
            var actualNumSpawners = q_spawners.CalculateEntityCount();

            var ecb = _ecb.CreateCommandBuffer().AsParallelWriter();

            Entities
                .ForEach((int entityInQueryIndex, in SpawnerEntityData spawnerEntity,in SpawnerNumberData spawnerNumber) =>
                {
                    var suppoedNumSpawners = spawnerNumber.Value;
                    if (suppoedNumSpawners > actualNumSpawners)
                    {
                        //Get the difference first.
                        var diffNumSpawner = suppoedNumSpawners - actualNumSpawners;
                        for (int i = 0; i < diffNumSpawner; i++)
                        {
                            var spawner = ecb.Instantiate(entityInQueryIndex, spawnerEntity.spawner);
#if UNITY_EDITOR
                            //Debugging purposes.
                            ecb.SetComponent(entityInQueryIndex, spawner, new PatternBlobIndexData { index = i});
                            ecb.SetComponent(entityInQueryIndex, spawner, new BulletBlobIndexData { index = i});
#endif
                        }
                    }
                }).ScheduleParallel();
            _ecb.AddJobHandleForProducer(Dependency);
        }
    }
}