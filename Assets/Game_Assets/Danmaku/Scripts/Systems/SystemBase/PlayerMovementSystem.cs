using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

namespace Example.Danmaku
{
    public class PlayerMovementSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            // Entities.ForEach((ref Translation translation, in PlayerInputData playerInput) => 
            // {
            //     int up = Input.GetKeyDown(playerInput.up) ? 1 : 0;
            //     int left = Input.GetKeyDown(playerInput.left) ? 1 : 0;
            //     int down = Input.GetKeyDown(playerInput.down) ? 1 : 0;
            //     int right = Input.GetKeyDown(playerInput.right) ? 1 : 0;


            //     translation.Value.x += right;
            //     translation.Value.x -= left;
            //     translation.Value.y += up;
            //     translation.Value.y -= down;
            // }).Run();
        }
    }
}