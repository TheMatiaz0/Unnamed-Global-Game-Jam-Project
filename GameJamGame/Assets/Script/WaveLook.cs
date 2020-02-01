﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Cyberevolver;
using Cyberevolver.Unity;

public class WaveLook : MonoBehaviourPlus
{

    [SerializeField]
    [AssetOnly]
    private SpriteRenderer prefab;
    

    [SerializeField]
    private Sprite[] sprites;
    [SerializeField]
    private Vector2 elementSize;
    [SerializeField]
    private Vector2Int elementsQuanity;



    private SpriteRenderer[] elements;


    private void Generate()
    {
        for(int x=0;x<elements.x;x++)
            for(int y=0;y<elements.y;y++)
            {
                var obj = Instantiate(prefab, (Vector2)this.transform.position + new Vector2(x, y), Quaternion.identity);

            }
    }
    protected override void OnGUI()
    {
        base.OnGUI();
        Gizmos.color = Color.red;
        Gizmos.DrawCube(this.transform.position, elements * elementSize);

    }
}