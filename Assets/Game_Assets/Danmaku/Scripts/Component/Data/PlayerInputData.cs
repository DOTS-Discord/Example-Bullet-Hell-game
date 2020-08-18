using UnityEngine;
using Unity.Entities;

namespace Example.Danmaku
{
    //Unused component
    //Supposed to attached to the player and make it move around
    //via moving
    //But I didn't use it yet in a system
    [GenerateAuthoringComponent]
    public struct PlayerInputData : IComponentData
    {
        public KeyCode up;
        public KeyCode left;
        public KeyCode down;
        public KeyCode right;
    }
}