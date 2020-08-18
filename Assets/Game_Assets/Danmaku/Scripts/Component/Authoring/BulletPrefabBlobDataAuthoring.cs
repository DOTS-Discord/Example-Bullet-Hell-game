using Unity.Collections;
using Unity.Entities;
using UnityEngine;
using System.Collections.Generic;

namespace Example.Danmaku
{
    //again, turning various bullet hell prefabs into blobassets
    public class BulletPrefabBlobDataAuthoring : MonoBehaviour, IConvertGameObjectToEntity, IDeclareReferencedPrefabs
    {
        //Think of this as an array.
        //Essentially: public GameObject[] bulletPrefab
        public BulletPrefabReorderable bulletPrefab;

        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            using (BlobBuilder blobBuilder = new BlobBuilder(Allocator.Temp))
            {
                ref BulletPrefabBlobAsset bulletBlob = ref blobBuilder.ConstructRoot<BulletPrefabBlobAsset>();
                BlobBuilderArray<Entity> bulletArr = blobBuilder.Allocate(ref bulletBlob.bulletPrefab, bulletPrefab.Length);

                for (int i = 0; i < bulletPrefab.Length; i++)
                {
                    bulletArr[i] = conversionSystem.GetPrimaryEntity(bulletPrefab[i]);
                }

                dstManager.World.GetExistingSystem<BulletSpawnSystem>().bulletDataBlob = blobBuilder.CreateBlobAssetReference<BulletPrefabBlobAsset>(Allocator.Persistent);
            }
        }

        //You need this if you want to convert the prefabs into entities 
        //(but they're just there to be instanciated in the Default World proper) 
        public void DeclareReferencedPrefabs(List<GameObject> referencedPrefabs)
        {
            referencedPrefabs.AddRange(bulletPrefab.Collection);
        }
    }
}
