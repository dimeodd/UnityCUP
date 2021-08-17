using UnityEngine;
using CUP;

[RequireComponent(typeof(Rigidbody2D))]
public class StopPhys2D_ExempleClass : ChronoBehaviour
{
    [SerializeField] Rigidbody2D rig;

    protected override void ChronoStart()
    {
        // Connect Rigidbody2D to Pause
        InitRigidbody2D(rig);
    }
}
