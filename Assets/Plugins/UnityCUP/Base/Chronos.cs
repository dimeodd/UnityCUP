using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CUP
{

    [AddComponentMenu("UnityCUP/WorldComponent")]
    public sealed class Chronos : MonoBehaviour
    {
        public static RealChronos Main { get; private set; } = new RealChronos();

        bool al;

        public void Switch()
        {
            Main.SetTimeline(al);
            al = !al;
        }

        void Update() => Main.MainChronoUpdate();
        void FixedUpdate() => Main.MainChronoFixedUpdate();
    }

    public class RealChronos
    {
        public bool WorldIsMove { get; private set; } = true;

        public event Action event_WorldUpdate = delegate { };
        public event Action event_WorldIEnumer = delegate { };
        public event Action event_WorldFixedUpdate = delegate { };
        public event Action<bool> event_WorldOnPause = delegate { };

        public event Action event_UiUpdate = delegate { };

public void MainChronoUpdate()
{
    if (WorldIsMove)
    {
        event_WorldIEnumer();
        event_WorldUpdate();
    }

    event_UiUpdate();
}

        public void MainChronoFixedUpdate()
        {
            if (WorldIsMove)
                event_WorldFixedUpdate();
        }

        public void SetTimeline(bool isMove)
        {
            WorldIsMove = isMove;
            event_WorldOnPause(isMove);
        }
    }
}