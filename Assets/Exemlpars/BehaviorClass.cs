using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviorClass : MonoBehaviour
{
    protected void Start()
    {
        Debug.Log("Mono Start");

        StartCoroutine(MyRoutine(3));

        // enabled = false;
        // for (int i = 0; i < 10; i++)
        // {
        //     StartCoroutine(MyRoutine(i));
        // }
        pos = transform.position;
        x = Random.Range(0.0f, 1.0f);
        Time.timeScale = 0;
    }
    Vector3 pos;
    float x = 0;

    protected void Update()
    {
        transform.position = pos + new Vector3(Mathf.Sin(x * Mathf.PI), Mathf.Cos(x * Mathf.PI), 0);
        x = (x + Time.deltaTime * 0.5f) % 2;
    }

    float f = 0;
    bool rev;

    protected void FixedUpdate()
    {
        GetComponent<SpriteRenderer>().color = new Color(f, f, f, 1);
        if (rev)
            f = (f - Time.fixedDeltaTime * 0.5f);
        else
            f = (f + Time.fixedDeltaTime * 0.5f);

        if (f >= 0.9f) rev = true;
        if (f <= 0.1f) rev = false;
    }

    IEnumerator MyRoutine(float time)
    {
        yield return new WaitForSeconds(time);
        Debug.Log($"Mono wait {time} sec |" + System.DateTime.Now + "|" + System.DateTime.Now.Millisecond);
    }
}
