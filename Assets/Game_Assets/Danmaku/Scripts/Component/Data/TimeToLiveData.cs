using System.Collections;
using Unity.Entities;
using UnityEngine;
using UnityEngine.Timeline;

namespace Example.Danmaku
{
    [GenerateAuthoringComponent]
    public struct TimeToLiveData : IComponentData
    {
        [HideInInspector] public float lifetime;
    }
}