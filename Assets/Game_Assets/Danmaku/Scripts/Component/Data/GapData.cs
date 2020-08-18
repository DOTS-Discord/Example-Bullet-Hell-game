using Unity.Entities;
using UnityEngine;

namespace Example.Danmaku
{
    [GenerateAuthoringComponent]
    public struct GapData : IComponentData
    {
        public float timeGap;
        [HideInInspector] public float countdown;
        [HideInInspector] public bool active;
    }
}