using System.Collections;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("escape")) {
			Application.Quit ();
		}
		
	}

	void OnTriggerEnter2D(Collider2D collision){
		if (collision.gameObject.tag == "Player") {
			StartCoroutine (LoadDeathScene());
		} else {
			SceneManager.LoadScene (2);
		}
	}

	IEnumerator LoadDeathScene(){
		float timeOut = 0.5f;
		yield return new WaitForSeconds (timeOut);
		SceneManager.LoadScene (4);
	}
}
