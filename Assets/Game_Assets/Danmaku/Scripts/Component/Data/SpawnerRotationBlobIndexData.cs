using Unity.Entities;
using UnityEngine;

namespace Example.Danmaku
{
    //Attaches to the spawner manager
    //Whats the rotation of the spawners
    [GenerateAuthoringComponent]
    public struct SpawnerRotationBlobIndexData : IComponentData
    {
        [HideInInspector] public int Value;
    }
}