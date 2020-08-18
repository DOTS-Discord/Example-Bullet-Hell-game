using Unity.Entities;

namespace Example.Danmaku
{
    public struct BulletBehaviourData
    {
        public float acceleration;
        public float targetspeed;
        public BehaviourTag behaviour;
        public BehaviourApplicaiton applicaiton;
    }

    public struct BulletBehaviourBlobAsset
    {
        public BlobArray<BulletBehaviourData> bulletBehaviourDataArray;
    } 
}