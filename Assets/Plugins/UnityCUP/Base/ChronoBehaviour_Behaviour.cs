using UnityEngine;

namespace CUP
{
    public abstract partial class ChronoBehaviour
    {
        protected void InitBehaviour(Behaviour component)
        {
            OnPauseAction += isPlay =>
            {
                component.enabled = isPlay;
            };
        }
    }
}
