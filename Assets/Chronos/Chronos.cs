using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chronos : MonoBehaviour
{
    public static RealChronos Main { get; private set; } = new RealChronos();

    bool isMove;

    [ContextMenu("Switch Time")]
    void Switch()
    {
        Main.SetTimeline(isMove);
        isMove = !isMove;
    }

    void Update() => Main.MainChronoUpdate();
    void FixedUpdate() => Main.MainChronoFixedUpdate();
}

public class RealChronos
{
    bool WorldIsMove = true;

    event Action event_WorldUpdate = delegate { };
    event Action event_WorldIEnumer = delegate { };
    event Action event_WorldFixedUpdate;
    event Action event_UiUpdate = delegate { };

    public void MainChronoUpdate()
    {
        if (WorldIsMove)
        {
            event_WorldUpdate();
            event_WorldIEnumer();
        }

        event_UiUpdate();
    }

    public void MainChronoFixedUpdate()
    {
        if (WorldIsMove & event_WorldUpdate != null)
            event_WorldFixedUpdate();
    }

    public void SetTimeline(bool isMove)
    {
        WorldIsMove = isMove;
    }

    public void AddUpdate(Action listner)
    {
        event_WorldUpdate += listner;
    }
    public void RemoveUpdate(Action listner)
    {
        event_WorldUpdate += listner;
    }

    public void AddFixedUpdate(Action listner)
    {
        event_WorldFixedUpdate += listner;
    }
    public void RemoveFixedUpdate(Action listner)
    {
        event_WorldFixedUpdate += listner;
    }

    public void AddUiUpdate(Action listner)
    {
        event_UiUpdate += listner;
    }
    public void RemoveUiUpdate(Action listner)
    {
        event_UiUpdate += listner;
    }
}
