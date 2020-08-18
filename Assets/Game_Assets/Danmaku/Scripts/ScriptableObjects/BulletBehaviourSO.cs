using UnityEngine;


namespace Example.Danmaku
{
    
    [CreateAssetMenu(fileName = "New Bullet Behaviour", menuName="Danmaku/Bullet Behaviour")]
    public class BulletBehaviourSO : ScriptableObject
    {
        public float acceleration;
        public float targetspeed;
        public BehaviourTag behaviour;
        public BehaviourApplicaiton applicaiton;
    }
    public enum BehaviourTag : int
    {
        sine = 1,
        tangent = 2
    }
    public enum BehaviourApplicaiton : int
    {
        movement = 1,
        speed = 2
    }
}