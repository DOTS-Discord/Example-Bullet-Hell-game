using Unity.Entities;
using UnityEngine;

namespace Example.Danmaku
{
    //attaches to the spawner prefab.
    //tells the spawner what bullet to spawn.
    [GenerateAuthoringComponent]
    public struct BulletBlobIndexData : IComponentData
    {
        [HideInInspector] public int index;
    }
}