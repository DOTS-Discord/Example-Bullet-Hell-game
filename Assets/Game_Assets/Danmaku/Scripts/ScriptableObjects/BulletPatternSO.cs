using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

namespace Example.Danmaku
{
    //this SO is to aide me when I need a new pattern
    //each SO will be converted into "rows" in the bulletpattern blob asset
    [CreateAssetMenu(fileName ="New Bullet Pattern", menuName = "Danmaku/Bullet Pattern")]
    public class BulletPatternSO : ScriptableObject
    {
        public int bulletNumber;
        public float speed;
        public float lifetime;
        public int damage;
        public float2 displacementDistance;
        public float innerCircleSize;
        public float minRotation;
        public float maxRotation;
        public float FireTime;
        public float GapTime;
        public float StopTime;
    }
}