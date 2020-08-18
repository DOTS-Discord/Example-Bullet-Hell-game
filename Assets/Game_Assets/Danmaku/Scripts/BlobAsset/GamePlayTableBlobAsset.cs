using Unity.Entities;

namespace Example.Danmaku
{
    //TODO: Complete the master blob asset;
    public struct GamePlayTableData
    {
        public int bulletIndex;
        public int patternIndex;
        public int spawnerRotateIndex;
        public int spawnerMovementIndex;
        public int bulletBehaviourIndex;
    }
    public struct GamePlayeTableBlobAsset
    {
        public BlobArray<GamePlayTableData> GamePlayeTableBlob;
    }
}
