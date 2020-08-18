using Unity.Entities;
using UnityEngine;

namespace Example.Danmaku
{
    //Attaches to the spawner entity
    //tells the spawner what's the time gap between spwaning bullets
    [GenerateAuthoringComponent]
    public struct GapData : IComponentData
    {
        public float timeGap;
        [HideInInspector] public float countdown;
        [HideInInspector] public bool active;
    }
}