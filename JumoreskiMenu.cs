using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumoreskiMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void b1()
    {
        SceneManager.LoadScene("Jumoreski1",LoadSceneMode.Single);
    }
    public void b2()
    {
        SceneManager.LoadScene("Jumoreski2", LoadSceneMode.Single);
    }
    public void b3()
    {
        SceneManager.LoadScene("Jumoreski3", LoadSceneMode.Single);
    }
    public void b4()
    {
        SceneManager.LoadScene("Jumoreski4", LoadSceneMode.Single);
    }
    public void b5()
    {
        SceneManager.LoadScene("Jumoreski5", LoadSceneMode.Single);
    }
    public void b6()
    {
        SceneManager.LoadScene("Jumoreski6", LoadSceneMode.Single);
    }
    public void b7()
    {
        SceneManager.LoadScene("Jumoreski7", LoadSceneMode.Single);
    }
    public void b8()
    {
        SceneManager.LoadScene("Albums", LoadSceneMode.Single);
    }
    public void b9()
    {
        SceneManager.LoadScene("JumoreskiMenu2",LoadSceneMode.Single);
    }
}
