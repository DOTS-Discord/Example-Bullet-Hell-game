using System.Collections;
using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using Unity.Physics;

namespace Example.Danmaku
{
    //makes the bullet move forward according to its rotation that's set by the bullet spawn system
    [UpdateBefore(typeof(TransformSystemGroup))]
    public class BulletMoveFowardSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            var deltaTime = Time.DeltaTime;
            Entities
                .ForEach((ref Translation translation, in Rotation rotation, in BulletSpeedData bulletdata) =>
                {
                    translation.Value += (math.mul(rotation.Value, new float3(1, 0, 0)) * bulletdata.Value * deltaTime);
                }).ScheduleParallel();
        }
    }
}