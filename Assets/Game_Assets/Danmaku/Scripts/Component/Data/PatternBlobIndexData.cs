using Unity.Entities;
using UnityEngine;

namespace Example.Danmaku
{
    //attaches to the spawner.
    //tells the spawner that's the bullet pattern to take
    [GenerateAuthoringComponent]
    public struct PatternBlobIndexData : IComponentData
    {
        [HideInInspector] public int index;
    }
}