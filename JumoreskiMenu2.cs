using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumoreskiMenu2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void b1()
    {
        SceneManager.LoadScene("Jumoreski8", LoadSceneMode.Single);
    }
    public void b2()
    {
        SceneManager.LoadScene("Jumoreski9", LoadSceneMode.Single);
    }
    public void b3()
    {
        SceneManager.LoadScene("Jumoreski10", LoadSceneMode.Single);
    }
    public void b4()
    {
        SceneManager.LoadScene("Jumoreski11", LoadSceneMode.Single);
    }
    public void b5()
    {
        SceneManager.LoadScene("Jumoreski12", LoadSceneMode.Single);
    }
    public void b6()
    {
        SceneManager.LoadScene("Jumoreski13", LoadSceneMode.Single);
    }
    public void b7()
    {
        SceneManager.LoadScene("Jumoreski14", LoadSceneMode.Single);
    }
    public void b8()
    {
        SceneManager.LoadScene("Albums", LoadSceneMode.Single);
    }
    public void b9()
    {
        SceneManager.LoadScene("JumoreskiMenu3", LoadSceneMode.Single);
    }
    public void b10()
    {
        SceneManager.LoadScene("JumoreskiMenu", LoadSceneMode.Single);
    }
}
