using MyBox;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Example.Danmaku
{
    [System.Serializable]
    public class ReorderableTransforms : Reorderable<WayPointSO> { }
    public class WayPointBlobDataAuthoring : MonoBehaviour, IConvertGameObjectToEntity
    {
#if UNITY_EDITOR
        public int DrawGizmoOn;
#endif
        public ReorderableTransforms WayPoints;

#if UNITY_EDITOR
        private void OnDrawGizmos()
        {
            int u = DrawGizmoOn;
            if (WayPoints[u] != null)
            {
                var point = WayPoints[u].transforms;
                for (int i = 0; i < point.Length; i++)
                {
                    Transform transform = new GameObject().transform;
                    transform.position = new Vector3(point[i].x, point[i].y, 0);
                    if (transform.position != null)
                    {
                        Gizmos.DrawWireCube(transform.position, Vector3.one * .3f);
                        if (i > 0)
                        {
                            Gizmos.DrawLine(transform.position, new Vector3(point[i - 1].x, point[i - 1].y, 0));
                        }
                        if (i == point.Length - 1)
                        {
                            Gizmos.DrawLine(transform.position, new Vector3(point[0].x, point[0].y, 0));
                        }
                    }

                }
            }
        }
#endif

        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {

        }
    }
}