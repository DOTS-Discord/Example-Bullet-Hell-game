using Unity.Entities;
using Unity.Mathematics;

namespace Example.Danmaku
{
    //Unused component
    //Supposed to make the player move
    [GenerateAuthoringComponent]
    public struct PlayerMovementData : IComponentData
    {
        public int2 direction;
    }
}