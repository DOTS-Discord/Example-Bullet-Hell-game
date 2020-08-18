using MyBox;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace Example.Danmaku
{
    //Reorderable BulletBehaviorSO when attached to the editor
    [System.Serializable]
    public class BulletBehaviourReorderable : Reorderable<BulletBehaviourSO>
    { }

    //I think I commented this out because I was testing a few stuff.

    //But, this IConvertGameObjecToEntity is responsible to create the BlobAsset proper
    //I would convert the Array of the SO's into a blob asset
    
    //Note that each IConvertGameObject that is responsible for creating blob assets gives the referrences to the 
    //System level. Not the Component level.
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