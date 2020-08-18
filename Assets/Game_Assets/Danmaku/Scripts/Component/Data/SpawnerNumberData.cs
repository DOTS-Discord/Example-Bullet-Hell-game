using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

namespace Example.Danmaku
{
    //Attaches to the spawner manager
    //what's the number of spawners
    public struct SpawnerNumberData : IComponentData
    {
        public int Value;
    }
}