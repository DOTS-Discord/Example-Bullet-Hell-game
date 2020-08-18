using MyBox;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Rendering;

namespace Example.Danmaku
{
    [System.Serializable]
    public struct PatternData
    {
        public int bulletNumber;
        public float speed;
        public float lifetime;
        public int damage;
        public float2 distanceFromSpawn;
        public float innerCircleSize;
        public float minRotation;
        public float maxRotation;
        public float FireTime;
        public float GapTime;
        public float StopTime;
    }

    public struct PatternBlobAsset
    {
        public BlobArray<PatternData> patternDataArray;
    }
}