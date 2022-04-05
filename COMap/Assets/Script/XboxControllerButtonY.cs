using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class XboxControllerButtonY : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Xbox Y")) {
			//SocialVulnerabilityButton.onClick.Invoke();
		
			GetComponent<Button>().onClick.Invoke();

		}
	}


}