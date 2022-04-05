using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoreDataOptionsTimerMenu : MonoBehaviour {

	//private Action action;
	private float timer;
	public GameObject MoreDataOptions;
	private MoreDataOptionsTimerMenu Menu1;


	
	public MoreDataOptionsTimerMenu(float timer){
		//this.action = action;
		this.timer = timer;
	}

		
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer < 0) {
			// Trigger the action
			if (MoreDataOptions.activeInHierarchy == true)
				MoreDataOptions.SetActive(false);
			else
				MoreDataOptions.SetActive(true);
			
		}
//	void MenuAppear() {
	//	if (MoreDataOptions.activeInHierarchy == true)
	//		MoreDataOptions.SetActive(false);
	//	else
		///	MoreDataOptions.SetActive(true);
  //	}	
	
	//void start () {
        	//StartCoroutine(buttonappear());
		//Menu1 = new MoreDataOptionsTimerMenu(MenuAppear, 3f);
  //	}


	}


}
