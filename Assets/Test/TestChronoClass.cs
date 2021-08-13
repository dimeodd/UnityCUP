using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestChronoClass : ChronoBehaviour
{
    protected override void ChronoStart()
    {
        Debug.Log("Chronos Start");

        Chronos.Main.AddUpdate(ChronoUpdate);
    }
    float x = 0;

    // protected  void Update()
    protected override void ChronoUpdate()
    {
        transform.position = new Vector2(Mathf.Sin(x * Mathf.PI), Mathf.Cos(x * Mathf.PI));
        x = (x + Time.deltaTime * 0.5f) % 2;
    }
}
