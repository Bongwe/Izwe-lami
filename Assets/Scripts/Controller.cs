using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    public float MaxSpeed = 10.0f;
	private float horizontalInput;
	private float verticalInput;
    private Rigidbody2D rigidbody2D;
	private Transform groundSensor;

    // Use this for initialization
    private void Start ()
	{
	    this.rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	private void Update ()
	{
	    this.horizontalInput = Input.GetAxis("Horizontal");
		this.verticalInput = Input.GetAxis("Vertical");
	}

    //FixedUpdate is called every fixed framerate frame
    private void FixedUpdate()
    {
		var moveSpeed = new Vector2(horizontalInput * this.MaxSpeed,verticalInput * this.MaxSpeed);
        this.rigidbody2D.velocity = moveSpeed;
    }


}
