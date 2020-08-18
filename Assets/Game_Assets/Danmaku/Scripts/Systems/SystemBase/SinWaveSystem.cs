using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine.Jobs;

namespace Example.Danmaku
{
    //Make bullet move in a sine wave
    public class SinWaveSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            //TODO: 
            //var elapsed = Time.ElapsedTime;
            //Entities
            //    .WithAll<SineTag>()
            //    .ForEach((ref Rotation rotation) => 
            //    {
            //        //math.sin(elapsed * speed or frequency) * magnitude
            //        rotation.Value = /*math.mul(rotation.Value, */quaternion.Euler(0,0, math.radians((float)(math.sin(elapsed * 10) * 100)))/*)*/;
            //    }).Schedule();
        }
    }
}