using UnityEngine;

namespace CUP
{
    public abstract partial class ChronoBehaviour
    {
        Vector2 TempVelocity;

        protected void InitRigidbody2D(Rigidbody2D component)
        {
            OnPauseAction += isPlay =>
            {
                 component.simulated = isPlay;

                // This frize the objects (you can interact with them), but not optimised
                // 
                // if (isPlay)
                // {
                //     component.isKinematic = false;
                //     component.WakeUp();
                // }
                // else
                // {
                //     component.Sleep();
                //     component.isKinematic = true;
                // }
            };
        }
    }
}
