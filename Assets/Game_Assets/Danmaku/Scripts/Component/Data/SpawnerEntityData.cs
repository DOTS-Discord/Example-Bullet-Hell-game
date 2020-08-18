using Unity.Entities;

namespace Example.Danmaku
{
    //Attaches to the spawner manager
    //the spawner prefab
    public struct SpawnerEntityData : IComponentData
    {
        public Entity spawner;
    }
}