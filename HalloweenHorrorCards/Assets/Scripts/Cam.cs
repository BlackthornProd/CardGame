using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public float speed;

	private Camera cam;

	private void Start()
	{
		cam = GetComponent<Camera>();
	}

	private void Update()
	{
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate(Vector2.left * speed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Translate(Vector2.right * speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(Vector2.down * speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(Vector2.up * speed * Time.deltaTime);
		}

		if(Input.GetKeyDown(KeyCode.S)){
			cam.orthographicSize += 1;
		}
		if (Input.GetKeyDown(KeyCode.Z))
		{
			cam.orthographicSize -= 1;
		}



		}
}
