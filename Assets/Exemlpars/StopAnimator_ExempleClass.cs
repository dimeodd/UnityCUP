using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class StopAnimator_ExempleClass : MonoBehaviour
{
  [SerializeField] Animator rig;

    protected override void ChronoStart()
    {
        // Connect Animator to Pause
        InitBehaviour(rig);
    }
}
