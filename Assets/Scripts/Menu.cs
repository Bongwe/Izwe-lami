using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Quit(){
		Application.Quit ();
	}

	public void Play(){
		SceneManager.LoadScene (1);
	}

	public void Credits(){
		SceneManager.LoadScene (5);
	}

	public void MainMenu(){
		SceneManager.LoadScene (0);
	}
}
