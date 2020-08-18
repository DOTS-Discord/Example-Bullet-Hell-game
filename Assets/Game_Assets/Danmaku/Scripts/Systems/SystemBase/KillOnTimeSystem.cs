using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;

namespace Example.Danmaku
{
    //Kills the entity when their Time to Live <= 0
    [UpdateAfter(typeof(BulletMoveFowardSystem))]
    [UpdateAfter(typeof(TransformSystemGroup))]
    public class KillOnTimeSystem : SystemBase
    {
        EndSimulationEntityCommandBufferSystem _eecb;
        protected override void OnCreate()
        {
            _eecb = World.GetOrCreateSystem<EndSimulationEntityCommandBufferSystem>();
        }
        protected override void OnUpdate()
        {
            var ecb = _eecb.CreateCommandBuffer().AsParallelWriter();
            var deltaTime = Time.DeltaTime;

            Entities.ForEach((Entity entity, int entityInQueryIndex, ref TimeToLiveData ttl) =>
            {
                ttl.lifetime -= deltaTime;
                
                if (ttl.lifetime <= 0)
                {
                    ecb.DestroyEntity(entityInQueryIndex, entity);
                }

            }).ScheduleParallel();

            _eecb.AddJobHandleForProducer(this.Dependency);
        }
    }
}