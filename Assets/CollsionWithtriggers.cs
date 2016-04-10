﻿using UnityEngine;
using System.Collections;

public class CollsionWithtriggers : MonoBehaviour
{
    public bool isRed = false;
    public bool isGreen = false;
    public bool isBlue = false;
    public bool isPurple = false;

    // Use this for initialization
    void Start ()
    {
        PlayerPrefs.SetInt("Red", 0);
        PlayerPrefs.SetInt("Green", 0);
        PlayerPrefs.SetInt("Blue", 0);
        PlayerPrefs.SetInt("Purple", 0);

	}
	
	void OnTriggerEnter2D(Collider2D coll)
    {
        if(isPurple)
        {
            PlayerPrefs.SetInt("Purple", 1);
            Debug.Log("P");
        }
        else if(isGreen)
        {
            PlayerPrefs.SetInt("Green", 1);
            Debug.Log("G");
        }
        else if(isBlue)
        {
            PlayerPrefs.SetInt("Blue", 1);
            Debug.Log("B");
        }
        else if(isRed)
        {
            PlayerPrefs.SetInt("Red", 1);
            Debug.Log("R");
        }
    }
}
