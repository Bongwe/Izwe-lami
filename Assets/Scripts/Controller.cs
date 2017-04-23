using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Controller : MonoBehaviour
{
    public float MaxSpeed = 10.0f;
	private float horizontalInput;
	private float verticalInput;
    private Rigidbody2D rigidbody2D;
	private Transform groundSensor;
	public AudioSource walking;
	float timeleft = 1.0f;
	float walkingSoundDelay;
	bool isOnTheWall = false;
	public AudioSource hitWall;

    // Use this for initialization
    private void Start ()
	{
	    this.rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
		walkingSoundDelay = timeleft;
	}
	
	// Update is called once per frame
	private void Update ()
	{
	    this.horizontalInput = Input.GetAxis("Horizontal");
		this.verticalInput = Input.GetAxis("Vertical");
		if (Input.GetKey("escape")) {
			Application.Quit ();
		}
	}

    //FixedUpdate is called every fixed framerate frame
    private void FixedUpdate()
    {
		var moveSpeed = new Vector2(horizontalInput * this.MaxSpeed,verticalInput * this.MaxSpeed);
        this.rigidbody2D.velocity = moveSpeed;
		walkingSoundDelay -= Time.deltaTime;
		if (!isOnTheWall) {
			WalkingSound ();
		}
    }

	void WalkingSound(){
		if (Input.GetKey("up") && walkingSoundDelay <= 0 ) {
			walking.Play ();
			walkingSoundDelay = timeleft;
		} else if (Input.GetKey("down") && walkingSoundDelay <= 0 ) {
			walking.Play ();
			walkingSoundDelay = timeleft;
		}else if (Input.GetKey("left") && walkingSoundDelay <= 0 ) {
			walking.Play ();
			walkingSoundDelay = timeleft;
		}else if (Input.GetKey("right") && walkingSoundDelay <= 0 ) {
			walking.Play ();
			walkingSoundDelay = timeleft;
		}
	}

	void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.tag == "Wall"){
			isOnTheWall = true;
			hitWall.Play ();
		}
	}

	void OnCollisionExit2D(Collision2D collision){
		if(collision.gameObject.tag == "Wall"){
			isOnTheWall = false;
		}
	}

}
