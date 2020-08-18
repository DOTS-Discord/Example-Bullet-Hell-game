using Unity.Entities;
using UnityEngine;

namespace Example.Danmaku
{
    [GenerateAuthoringComponent]
    public struct BulletBlobIndexData : IComponentData
    {
        [HideInInspector] public int index;
    }
}