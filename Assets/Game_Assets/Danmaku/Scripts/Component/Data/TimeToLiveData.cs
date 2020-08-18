using System.Collections;
using Unity.Entities;
using UnityEngine;
using UnityEngine.Timeline;

namespace Example.Danmaku
{
    //Attaches to the bullet
    //how much time does missed bullets needs to live before gets destroyed
    [GenerateAuthoringComponent]
    public struct TimeToLiveData : IComponentData
    {
        [HideInInspector] public float lifetime;
    }
}