using MyBox;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace Example.Danmaku
{
    [System.Serializable]
    public class BulletBehaviourReorderable : Reorderable<BulletBehaviourSO>
    { }
    public class BulletBehaviourBlobDataAuthoring : MonoBehaviour, IConvertGameObjectToEntity
    {
        public BulletBehaviourReorderable bulletBehaviour;
        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
			// 	//TODO: assign builder to a system or comoponent;
            // using (BlobBuilder blobBuilder = new BlobBuilder(Allocator.Temp))
            // {
            //     ref BulletBehaviourBlobAsset BulletBehaviourBlob = ref blobBuilder.ConstructRoot<BulletBehaviourBlobAsset>();
			// 	BlobBuilderArray<BulletBehaviourData> bulletBehaviourArr = blobBuilder.Allocate(ref BulletBehaviourBlob.bulletBehaviourDataArray, bulletBehaviour.Length);
			// 	for (int i = 0; i < bulletBehaviour.Length; i++)
			// 	{
			// 		bulletBehaviourArr[i] = new BulletBehaviourData
			// 		{
			// 			acceleration = bulletBehaviour[i].acceleration,
			// 			applicaiton = bulletBehaviour[i].applicaiton,
			// 			behaviour = bulletBehaviour[i].behaviour,
			// 			targetspeed = bulletBehaviour[i].targetspeed
			// 		};
			// 	}
            //     //dstManager.World.GetExistingSystem<BulletSpawnSystem>().bulletDataBlob = blobBuilder.CreateBlobAssetReference<BulletPrefabBlobAsset>(Allocator.Persistent);
            // }
        }
    }
}