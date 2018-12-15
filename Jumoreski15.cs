using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jumoreski15 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void b1()
    {
        SceneManager.LoadScene("Jumoreski16", LoadSceneMode.Single);
    }
    public void b2()
    {
        SceneManager.LoadScene("Jumoreski14", LoadSceneMode.Single);
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
