using UnityEngine;

namespace Example.Danmaku
{
    public class GamePlayTableBlobDataAuthoring : MonoBehaviour /*, IConvertGameObjectToEntity*/
    {
        // public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        // {
        //     using (BlobBuilder blobBuilder = new BlobBuilder(Allocator.Temp))
        //     {
        //         ref SpawnerRotationBlobAsset spwnRot = ref blobBuilder.ConstructRoot<SpawnerRotationBlobAsset>();
        //         BlobBuilderArray<SpawnerRotationData> spwnRotArr = blobBuilder.Allocate(ref spwnRot.spawnerRotationDataArray, spawnerRotation.Length);
                
        //         for (int i = 0; i < spawnerRotation.Length; i++)
        //         {
                    
        //         }

        //         dstManager.World.GetExistingSystem<SpawnerRotateSystem>().spawnerRotDataBlob = blobBuilder.CreateBlobAssetReference<SpawnerRotationBlobAsset>(Allocator.Persistent);
        //     }

        // }
    }
    
}
