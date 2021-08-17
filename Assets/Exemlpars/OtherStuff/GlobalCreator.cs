using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCreator : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] int CountX;
    [SerializeField] int pCountY;

    public Text text;


    private void Start()
    {
        GameObject go;
        Vector2 tr = transform.position;
        for (int y = 0; y < pCountY; y++)
        {
            for (int x = 0; x < CountX; x++)
            {
                go = Instantiate(prefab);

                go.transform.position = tr + new Vector2(x, y);
            }
        }
        text.text = (pCountY * CountX).ToString();
    }
}

