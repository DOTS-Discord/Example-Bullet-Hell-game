using UnityEngine;
using System.Collections;
using Unity.Entities;

namespace Example.Bootstrap
{
    public class Bootstrap
    {
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