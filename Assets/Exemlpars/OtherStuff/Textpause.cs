using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CUP;

public class Textpause : ChronoBehaviour
{
    public Text text;

    protected override void ChronoStart()
    {
        // Non safe method!!! If you realy need this, better use "ChronoBehavior.OnPauseAction += changeText", becouse it safe. NEVER CLEAN IT. You can break Phys2d and Animator Pause on this GameObject
        Chronos.Main.event_WorldOnPause += changeText;

        text.text = "Stop";
    }
    private void OnDestroy()
    {
        // Non safe method!!! "ChronoBehavior.OnPauseAction -= changeText" you dont need to use it, becouse it safe
        Chronos.Main.event_WorldOnPause -= changeText;
    }

    void changeText(bool isPlay)
    {
        text.text = isPlay ? "Stop" : "Play";
    }
}