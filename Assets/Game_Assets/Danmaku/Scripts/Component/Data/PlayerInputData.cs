using UnityEngine;
using Unity.Entities;

namespace Example.Danmaku
{
    [GenerateAuthoringComponent]
    public struct PlayerInputData : IComponentData
    {
        public KeyCode up;
        public KeyCode left;
        public KeyCode down;
        public KeyCode right;
    }
}