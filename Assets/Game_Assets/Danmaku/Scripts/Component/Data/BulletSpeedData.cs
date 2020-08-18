using System.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Example.Danmaku
{
    //Attaches to the bullet prefabs.
    //tells the bullet what's the speed.    
    [GenerateAuthoringComponent]
    public struct BulletSpeedData : IComponentData
    {
        [HideInInspector] public float Value;
    }
}