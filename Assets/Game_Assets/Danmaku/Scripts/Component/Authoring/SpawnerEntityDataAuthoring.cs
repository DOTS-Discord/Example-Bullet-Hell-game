using MyBox;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

namespace Example.Danmaku
{
    //So the spawner entity will need this.

    //Just like games such as touhou (the only danmaku game i know)
    //There can be plenty of spawn points with different bullets

    //Now I believe I made this to be able to spawn multiple spawners as much as I want
    //and each spawner points to the gameplay table.
    //but i can't remember if I did it.
    //you can check in for me XD
    public class SpawnerEntityDataAuthoring : MonoBehaviour, IConvertGameObjectToEntity, IDeclareReferencedPrefabs
    {
        [InitializationField] public int SpawnerNumber;
        [ReadOnly] public GameObject prefab;

        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            dstManager.SetArchetype(entity, dstManager.CreateArchetype(
                typeof(SpawnerEntityData),
                typeof(SpawnerNumberData)
                ));

            dstManager.SetComponentData(entity, new SpawnerEntityData
            {
                spawner = conversionSystem.GetPrimaryEntity(prefab)
            });

            dstManager.SetComponentData(entity, new SpawnerNumberData
            {
                Value = SpawnerNumber    
            });
        }
        public void DeclareReferencedPrefabs(List<GameObject> referencedPrefabs)
        {
            referencedPrefabs.Add(prefab);
        }
    }
}
