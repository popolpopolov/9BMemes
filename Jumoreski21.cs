﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jumoreski21 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void b1()
    {
        SceneManager.LoadScene("Jumoreski22", LoadSceneMode.Single);
    }
    public void b2()
    {
        SceneManager.LoadScene("Jumoreski20", LoadSceneMode.Single);
    }
    public void b3()
    {
        SceneManager.LoadScene("JumoreskiMenu", LoadSceneMode.Single);
    }
    public void b4()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
