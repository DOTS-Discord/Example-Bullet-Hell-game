using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Collections;
using Unity.Jobs;
using Unity.Physics.Systems;
using Unity.Burst;
using UnityEngine;
using UnityEngine.UIElements;

namespace Example.Danmaku
{
    //See if the bullet gets hit
    //if hit, get destroyed.
    [UpdateAfter(typeof(EndFramePhysicsSystem))]
    public class BulletCollisionSystem : SystemBase
    {
        private BuildPhysicsWorld buildPhysicsWorld;
        private StepPhysicsWorld stepPhysicsWorld;
        protected override void OnCreate()
        {
            base.OnCreate();
            buildPhysicsWorld = World.GetOrCreateSystem<BuildPhysicsWorld>();
            stepPhysicsWorld = World.GetOrCreateSystem<StepPhysicsWorld>();
        }

        [BurstCompile]
        private struct CheckCollisionJob : ITriggerEventsJob
        {
            [ReadOnly] public ComponentDataFromEntity<PlayerTag> allPlayers;
            [ReadOnly] public ComponentDataFromEntity<BulletTag> allBullets;

            public ComponentDataFromEntity<HealthData> allHealth;

            public void Execute(TriggerEvent triggerEvent)
            {
                Entity ea = triggerEvent.EntityA;
                Entity eb = triggerEvent.EntityB;

                if (allPlayers.HasComponent(ea) && allBullets.HasComponent(eb))
                {
                    HealthData bulletHealth = allHealth[eb];
                    bulletHealth.value -= 1;
                    allHealth[eb] = bulletHealth;
                }
                else if (allPlayers.HasComponent(eb) && allBullets.HasComponent(ea))
                {
                    HealthData bulletHealth = allHealth[ea];
                    bulletHealth.value -= 1;
                    allHealth[eb] = bulletHealth;
                }
            }
        }

        protected override void OnUpdate()
        {
            var job = new CheckCollisionJob();
            job.allPlayers = GetComponentDataFromEntity<PlayerTag>(true);
            job.allBullets = GetComponentDataFromEntity<BulletTag>(true);
            job.allHealth = GetComponentDataFromEntity<HealthData>(false);

            Dependency = job.Schedule(stepPhysicsWorld.Simulation, ref buildPhysicsWorld.PhysicsWorld, this.Dependency);
        }
    }
}