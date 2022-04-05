using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllButtonsDisableEnable : MonoBehaviour {

	public GameObject ButtonSVI;
	public GameObject ButtonCTP;
	public GameObject ButtonAI;
	public GameObject Slider;
	public GameObject SliderText;
	public GameObject MenuOff;

	public GameObject Question1Covid;
	public GameObject Q1YES;
	public GameObject Q1NO;

	public GameObject Question2TotalPop;

	public GameObject Q2YES;
	public GameObject Q2NO;

	public void ButtonSVIEnabled() {
		if (ButtonSVI.activeInHierarchy == true)
			ButtonSVI.SetActive(false);
		else
			ButtonSVI.SetActive(true);
	}

	public void ButtonCTPEnabled() {
		if (ButtonCTP.activeInHierarchy == true)
			ButtonCTP.SetActive(false);
		else
			ButtonCTP.SetActive(true);
	}

	public void ButtonAIEnabled() {
		if (ButtonAI.activeInHierarchy == true)
			ButtonAI.SetActive(false);
		else
			ButtonAI.SetActive(true);
	}

	public void SliderEnabled() {
		if (Slider.activeInHierarchy == true)
			Slider.SetActive(false);
		else
			Slider.SetActive(true);
	}

	public void SliderTextEnabled() {
		if (SliderText.activeInHierarchy == true)
			SliderText.SetActive(false);
		else
			SliderText.SetActive(true);
	}

	public void MenuOffEnabled() {
		if (MenuOff.activeInHierarchy == true)
			MenuOff.SetActive(false);
		else
			MenuOff.SetActive(true);
	}


	public void Question1CovidEnabled() {
		if (Question1Covid.activeInHierarchy == true)
			Question1Covid.SetActive(false);
		else
			Question1Covid.SetActive(true);
	}


	public void Q1YESEnabled() {
		if (Q1YES.activeInHierarchy == true)
			Q1YES.SetActive(false);
		else
			Q1YES.SetActive(true);
	}

	public void Q1NOEnabled() {
		if (Q1NO.activeInHierarchy == true)
			Q1NO.SetActive(false);
		else
			Q1NO.SetActive(true);
	}

	public void Question2TotalPopEnabled() {
		if (Question2TotalPop.activeInHierarchy == true)
			Question2TotalPop.SetActive(false);
		else
			Question2TotalPop.SetActive(true);
	}

	public void Q2YESEnabled() {
		if (Q2YES.activeInHierarchy == true)
			Q2YES.SetActive(false);
		else
			Q2YES.SetActive(true);
	}

	public void Q2NOEnabled() {
		if (Q2NO.activeInHierarchy == true)
			Q2NO.SetActive(false);
		else
			Q2NO.SetActive(true);
	}

}
