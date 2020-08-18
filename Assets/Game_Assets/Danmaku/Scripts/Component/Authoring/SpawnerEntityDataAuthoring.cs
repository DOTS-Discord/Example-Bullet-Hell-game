using MyBox;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

namespace Example.Danmaku
{
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
