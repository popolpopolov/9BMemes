using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NaziJumoreski12 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void b1()
    {
        SceneManager.LoadScene("NaziJumoreski13", LoadSceneMode.Single);
    }
    public void b2()
    {
        SceneManager.LoadScene("NaziJumoreski11", LoadSceneMode.Single);
    }
    public void b3()
    {
        SceneManager.LoadScene("Albums", LoadSceneMode.Single);
    }
    public void b4()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
