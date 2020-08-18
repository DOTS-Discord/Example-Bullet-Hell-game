using Unity.Entities;
using UnityEngine;

namespace Example.Danmaku
{
    [GenerateAuthoringComponent]
    public struct SpawnerRotationBlobIndexData : IComponentData
    {
        [HideInInspector] public int Value;
    }
}