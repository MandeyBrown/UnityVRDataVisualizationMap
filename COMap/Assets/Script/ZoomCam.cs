
using UnityEngine;

public class ZoomCam : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		// zoom in
		if ((Input.GetAxis ("Mouse ScrollWheel") > 0) || (Input.GetKey("e")) || (Input.GetButton("Right Trigger"))){
		//if ((Input.GetAxis ("Mouse ScrollWheel") > 0) || (Input.GetKey("e"))){
			GetComponent<Camera>().fieldOfView --;

		}
	
		

		// zoom out
		if ((Input.GetAxis ("Mouse ScrollWheel") < 0) || (Input.GetKey("q"))|| (Input.GetButton("Left Trigger"))){
		//if ((Input.GetAxis ("Mouse ScrollWheel") < 0) || (Input.GetKey("q"))){
			GetComponent<Camera>().fieldOfView ++;
		}
		
	}
}
