using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

namespace Example.Danmaku
{
    public struct SpawnerNumberData : IComponentData
    {
        public int Value;
    }
}