using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CUP;

public class Base_ExempleClass : ChronoBehaviour
{
    protected override void ChronoStart()
    {
        Debug.Log($"Crino Start |" + System.DateTime.Now + "|" + System.DateTime.Now.Millisecond);
        

        StartCoroutine(Numerator());

        pos = transform.position;
        x = Random.Range(0.0f, 1.0f);
    }

    Vector2 pos;
    float x = 0;

    // protected override void ChronoUpdate()
    // {
    //     transform.position = pos + new Vector2(Mathf.Sin(x * Mathf.PI), Mathf.Cos(x * Mathf.PI));
    //     x = (x + Time.deltaTime * 0.5f) % 2;
    // }

    float f = 0;
    bool rev;

    // protected override void ChronoFixedUpdate()
    // {
    //     GetComponent<SpriteRenderer>().color = new Color(1, f, f, 1);
    //     if (rev)
    //         f = (f - Time.fixedDeltaTime * 0.5f);
    //     else
    //         f = (f + Time.fixedDeltaTime * 0.5f);

    //     if (f >= 0.9f) rev = true;
    //     if (f <= 0.1f) rev = false;
    // }

    IEnumerator Numerator()
    {
        yield return new Waiter(4);
        Debug.Log("i moved UP");
        transform.position += Vector3.up * 3;
        yield return new Waiter(4);
        Debug.Log("i moved left");
        transform.position += Vector3.left * 6;
    }
}
