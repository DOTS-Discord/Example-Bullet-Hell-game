using Unity.Entities;
using UnityEngine;

namespace Example.Danmaku
{
    [GenerateAuthoringComponent]
    public struct HealthData : IComponentData
    {
        [HideInInspector] public int value;    
    }
}