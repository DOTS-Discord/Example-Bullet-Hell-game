using UnityEngine;
using Unity.Collections;
using Unity.Entities;
using System;

namespace Example.Danmaku
{
    [UpdateInGroup(typeof(GameObjectBeforeConversionGroup))]
    public class BlobAssetConstructor : GameObjectConversionSystem
    {
         //This system runs only once
        protected override void OnUpdate()
        {
            //BlobAssetReference<SpawnDataBlobAsset> spawnBlobRef;
            ////var spawnData = GetEntityQuery(typeof(SetSpawnData)).ToComponentArray<SetSpawnData>();
            ////var data = Array.FindAll(spawnData, datum => datum.SpawnData.Count > 0);

            //using (BlobBuilder blobBuilder = new BlobBuilder(Allocator.Temp))
            //{
            //    ref SpawnDataBlobAsset spawnBlob = ref blobBuilder.ConstructRoot<SpawnDataBlobAsset>();
            //    BlobBuilderArray<SpawnData> spawnArr = blobBuilder.Allocate(ref spawnBlob.spawnDataArray, 1);
            //    //for (int i = 0; i < data.Length; i++)
            //    //{
            //    //    spawnArr[i] = new SpawnData
            //    //    {
            //    //        minRotation = spawnData[0].SpawnData[i].minRotation
            //    //    };
            //    //}


            //    spawnArr[0] = new SpawnData { minRotation = 10 };
            //    spawnBlobRef = blobBuilder.CreateBlobAssetReference<SpawnDataBlobAsset>(Allocator.Persistent);
            //}

            //Entity spawnerEntity = DstEntityManager.CreateEntityQuery(typeof(SpawnPrefabData)).GetSingletonEntity();
            //DstEntityManager.AddComponentData(spawnerEntity, new SpawnerData
            //{
            //    spawnDataBlob = spawnBlobRef,
            //    index = 0
            //});
        }
    }
}