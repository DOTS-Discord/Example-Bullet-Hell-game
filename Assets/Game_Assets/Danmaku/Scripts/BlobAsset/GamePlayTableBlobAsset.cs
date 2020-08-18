using Unity.Entities;

namespace Example.Danmaku
{
    //TODO: Complete the master blob asset;
    //Hahaha. Cringe.

    //In any case, this GamePlayTable blob a lookup table is what supposed to keep the various behaviors,
    //bullet images, rotation of spawner, and spawner movement together.
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
