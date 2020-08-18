using MyBox;
using Unity.Mathematics;
using UnityEngine;

namespace Example.Danmaku
{
    //Haha. ignore this
    [System.Serializable]
    public class reorder : Reorderable<float2> { }
    
    [CreateAssetMenu(fileName = "New WayPoint", menuName = "Danmaku/Way Point")]
    public class WayPointSO : ScriptableObject
    {
		public reorder transforms;
    }
}