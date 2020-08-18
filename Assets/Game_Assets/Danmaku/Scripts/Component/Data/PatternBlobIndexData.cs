using Unity.Entities;
using UnityEngine;

namespace Example.Danmaku
{
    [GenerateAuthoringComponent]
    public struct PatternBlobIndexData : IComponentData
    {
        [HideInInspector] public int index;
    }
}