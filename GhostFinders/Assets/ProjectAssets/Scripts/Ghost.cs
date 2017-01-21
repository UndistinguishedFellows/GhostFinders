﻿using UnityEngine;
using System.Collections;



public class Ghost : MonoBehaviour {
    [SerializeField]
    public Scripts.colors type;
    Sprite sprite = null;
    [SerializeField]
    Sprite blue;
    [SerializeField]
    Sprite red;
    [SerializeField]
    Sprite green;
    [SerializeField]
    Sprite yellow;
    [SerializeField]
    Sprite magenta;
    [SerializeField]
    Sprite cyan;

    //------------------------------------------

    void Start ()
    {
        //Random ghost type at spawn
        type = (Scripts.colors)Random.Range(1, 6);        
        switch (type)
        {
            case Scripts.colors.blue:
                sprite = blue;
                break;
            case Scripts.colors.red:
                sprite = red;
                break;
            case Scripts.colors.green:
                sprite = green;
                break;
            case Scripts.colors.cyan:
                sprite = cyan;
                break;
            case Scripts.colors.magenta:
                sprite = magenta;
                break;
            case Scripts.colors.yellow:
                sprite = yellow;
                break;
            default:
                break;
        }
        gameObject.GetComponent<SpriteRenderer>().sprite = sprite;
    }
	
	void Update ()
    {
               
    }

    //------------------------------------------

    public void onGhostDetected(Scripts.colors flashLightColor)
    {
        Debug.Log("Ghost seen!");
    }

    public void onGhostLost()
    {
        Debug.Log("Ghost lost...");
    }



    //------------------------------------------
}
