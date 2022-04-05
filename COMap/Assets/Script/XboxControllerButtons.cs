using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class XboxControllerButtons : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Xbox B") || Input.GetKey("l")) {
			//SocialVulnerabilityButton.onClick.Invoke();
		
			GetComponent<Button>().onClick.Invoke();

		}
	}


}
