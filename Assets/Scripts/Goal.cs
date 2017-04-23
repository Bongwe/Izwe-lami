using System.Collections;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	public AudioSource goalReached;

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
		StartCoroutine (PlayAudioClip());
	}

	IEnumerator PlayAudioClip(){
		goalReached.Play ();
		while(goalReached.isPlaying){
			yield return null;
		}

		SceneManager.LoadScene (3);
	}
}
