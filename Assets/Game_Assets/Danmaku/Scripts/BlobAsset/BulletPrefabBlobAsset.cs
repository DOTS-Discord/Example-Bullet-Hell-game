using Unity.Entities;
using UnityEngine;
using MyBox;

namespace Example.Danmaku
{
    [System.Serializable]
    public class BulletPrefabReorderable : Reorderable<GameObject>
    { }
    public struct BulletPrefabBlobAsset
    {
        public BlobArray<Entity> bulletPrefab;
    } 
}