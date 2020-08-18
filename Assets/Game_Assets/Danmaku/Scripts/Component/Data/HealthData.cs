using Unity.Entities;
using UnityEngine;

namespace Example.Danmaku
{
    //Health for each entity.
    //attaches to the suppoed enemy, bullet (because I want to reuse it)
    //and the player
    [GenerateAuthoringComponent]
    public struct HealthData : IComponentData
    {
        [HideInInspector] public int value;    
    }
}