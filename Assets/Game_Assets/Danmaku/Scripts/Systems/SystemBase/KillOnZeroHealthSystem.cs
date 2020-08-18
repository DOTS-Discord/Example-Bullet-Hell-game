using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Physics;

namespace Example.Danmaku
{
    //Kills the entity when the entity's health reaches 0.
    [UpdateAfter(typeof(BulletCollisionSystem))]
    public class KillOnZeroHealthSystem : SystemBase
    {
        EndSimulationEntityCommandBufferSystem _eecb;
        protected override void OnCreate()
        {
            _eecb = World.GetOrCreateSystem<EndSimulationEntityCommandBufferSystem>();
        }
        protected override void OnUpdate()
        {
            var ecb = _eecb.CreateCommandBuffer().AsParallelWriter();
            Entities.ForEach((Entity entity, int entityInQueryIndex, in HealthData health) =>
            {
                if (health.value < 0)
                {
                    ecb.DestroyEntity(entityInQueryIndex, entity);
                }
            }).ScheduleParallel();

            _eecb.AddJobHandleForProducer(this.Dependency);
        }

    }
}