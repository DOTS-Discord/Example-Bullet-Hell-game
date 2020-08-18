using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEditor;
using UnityEditorInternal;
using UnityEditor.Rendering;
using MyBox;

namespace Example.Danmaku
{
    [System.Serializable]
    public class PatternDataReorArray : Reorderable<BulletPatternSO>
    { }
    public class PatternBlobDataAuthoring : MonoBehaviour, IConvertGameObjectToEntity
    {
        public PatternDataReorArray patternDataList;

        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            
            using (BlobBuilder blobBuilder = new BlobBuilder(Allocator.Temp))
            {
                ref PatternBlobAsset spawnBlob = ref blobBuilder.ConstructRoot<PatternBlobAsset>();
                BlobBuilderArray<PatternData> spawnArr = blobBuilder.Allocate(ref spawnBlob.patternDataArray, patternDataList.Length);
                for (int i = 0; i < patternDataList.Length; i++)
                {
                    spawnArr[i] = new PatternData
                    {
                        bulletNumber = patternDataList[i].bulletNumber,
                        speed = patternDataList[i].speed,
                        lifetime = patternDataList[i].lifetime,
                        damage = patternDataList[i].damage,
                        distanceFromSpawn = patternDataList[i].displacementDistance,
                        maxRotation = patternDataList[i].maxRotation,
                        minRotation = patternDataList[i].minRotation,
                        innerCircleSize = patternDataList[i].innerCircleSize
                    };
                }

                dstManager.World.GetExistingSystem<BulletSpawnSystem>().patternDataBlob = blobBuilder.CreateBlobAssetReference<PatternBlobAsset>(Allocator.Persistent);
            }

        }
    }


}
