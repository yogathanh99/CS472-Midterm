﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int Point;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        Point=0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text=Point.ToString();
    }
}
