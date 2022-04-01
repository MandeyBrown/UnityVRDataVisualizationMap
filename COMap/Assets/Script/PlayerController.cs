using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField] Transform playerCamera = null;
	[SerializeField] float mouseSensitivity = 3.5f;
	[SerializeField] bool lockCursor = true;

	[SerializeField] float walkSpeed = 20.0f;

	[SerializeField] [Range(0.0f, 0.5f)] float moveSmoothTime = 0.3f;

	float cameraPitch = 0.0f;

	CharacterController controller = null;

	Vector2 currentDir = Vector2.zero;

	// Use this for initialization
	void Start () {

		controller = GetComponent<CharacterController>();
		//if(lockCursor){
			//Cursor.lockState = CursorLockMode.Locked;
			//Cursor.visible = false;
		//}
		
	}
	
	// Update is called once per frame
	void Update () {
		UpdateMouseLook();
		UpdateMovement();
	}

	void UpdateMouseLook() {
		Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

		cameraPitch -= mouseDelta.y * mouseSensitivity;

		cameraPitch = Mathf.Clamp(cameraPitch, -90.0f, 90.0f);

		playerCamera.localEulerAngles = Vector3.right * cameraPitch;

		transform.Rotate(Vector3.up * mouseDelta.x * mouseSensitivity);

	}

	void UpdateMovement(){
		Vector2 inputDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

		inputDir.Normalize();

		Vector3 velocity = (transform.forward * inputDir.y) * walkSpeed;
		Vector3 velocity2 = (transform.right * inputDir.x) * walkSpeed;

		controller.Move(velocity * Time.deltaTime);
		controller.Move(velocity2 * Time.deltaTime);

	}
}
