using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

namespace Example.Danmaku
{
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