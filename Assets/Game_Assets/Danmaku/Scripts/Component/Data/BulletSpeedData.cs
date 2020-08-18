using System.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Example.Danmaku
{
    [GenerateAuthoringComponent]
    public struct BulletSpeedData : IComponentData
    {
        [HideInInspector] public float Value;
    }}