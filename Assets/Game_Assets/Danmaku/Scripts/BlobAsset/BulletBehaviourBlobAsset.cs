using Unity.Entities;

namespace Example.Danmaku
{
    //Bullet Behaviour takes stuff from the BulletBehaviourSO
    //to convert it to BlobAssets
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