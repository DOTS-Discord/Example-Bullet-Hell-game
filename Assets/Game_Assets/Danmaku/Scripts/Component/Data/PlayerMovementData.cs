using Unity.Entities;
using Unity.Mathematics;

namespace Example.Danmaku
{
    [GenerateAuthoringComponent]
    public struct PlayerMovementData : IComponentData
    {
        public int2 direction;
    }
}