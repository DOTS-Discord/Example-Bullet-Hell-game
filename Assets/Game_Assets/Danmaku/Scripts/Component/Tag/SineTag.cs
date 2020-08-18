using Unity.Entities;

namespace Example.Danmaku
{
    //a sine tag.
    //what entity must be affected by the SineWave System
    [GenerateAuthoringComponent]
    public struct SineTag : IComponentData
    {
    }
}