using Unity.Entities;
using UnityEngine;
using MyBox;

namespace Example.Danmaku
{
    //This creates a reorderable array on the inspector of type GameObject.
    [System.Serializable]
    public class BulletPrefabReorderable : Reorderable<GameObject>
    { }

    //This BlobArray of bulletPrefab is supposed to take in different "images" of bullets
    public struct BulletPrefabBlobAsset
    {
        public BlobArray<Entity> bulletPrefab;
    } 
}