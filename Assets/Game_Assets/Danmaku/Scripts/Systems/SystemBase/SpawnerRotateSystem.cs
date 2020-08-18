using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;

namespace Example.Danmaku
{
    //make the spawner spin
    public class SpawnerRotateSystem : SystemBase
    {
        //public BlobAssetReference<SpawnerRotationBlobAsset> spawnerRotDataBlob;
        //protected override void OnStopRunning()
        //{
        //    spawnerRotDataBlob.Dispose();
        //}
        protected override void OnUpdate()
        {
            //float delta = Time.DeltaTime;
            //double elapsed = Time.ElapsedTime;

            //var rotate = spawnerRotDataBlob;

            //Entities
            //    .WithNone<Prefab>()
            //    .WithAll<SpawnerTag>()
            //    .ForEach((ref Rotation rotation, in SpawnerRotationBlobIndexData rotateIndex) =>
            //    {
            //        ref var rotateBlob = ref rotate.Value;
                    
            //        var normalangle = math.normalize(rotation.Value);

            //        var direction = rotateBlob.spawnerRotationDataArray[rotateIndex.Value].direction == Direction.Left ? -1 : 1;
                    
            //        var angle = quaternion.AxisAngle(new float3(0, 0, direction), rotateBlob.spawnerRotationDataArray[rotateIndex.Value].speed * (float)delta);

            //        rotation.Value = math.mul(normalangle, angle);
            //    }).Run();
        }
    }
}