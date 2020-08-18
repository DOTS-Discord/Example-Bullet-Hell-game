using UnityEngine;
using System.Collections;
using Unity.Entities;

namespace Example.Bootstrap
{
    public class Bootstrap
    {
        //I was supposed to use this to make a PURE ECS version of this.
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public void FillBulletDataBuffer()
        {
        //    EntityManager entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
        //    entityManager.set
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public void FillSpawnMovementBufferData()
        {

        }

    }
}