using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SponsorsMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void b1()
    {
        SceneManager.LoadScene("Sponsors1", LoadSceneMode.Single);
    }
    public void b2()
    {
        SceneManager.LoadScene("Sponsors2", LoadSceneMode.Single);
    }
    public void b3()
    {
        SceneManager.LoadScene("Sponsors3", LoadSceneMode.Single);
    }
    public void b4()
    {
        SceneManager.LoadScene("Sponsors4", LoadSceneMode.Single);
    }
    public void b5()
    {
        SceneManager.LoadScene("Sponsors5", LoadSceneMode.Single);
    }
    public void b6()
    {
        SceneManager.LoadScene("Sponsors6", LoadSceneMode.Single);
    }
    public void b7()
    {
        SceneManager.LoadScene("Sponsors7", LoadSceneMode.Single);
    }
    public void b8()
    {
        SceneManager.LoadScene("Albums", LoadSceneMode.Single);
    }
    public void b9()
    {
        SceneManager.LoadScene("SponsorsMenu2", LoadSceneMode.Single);
    }
}
