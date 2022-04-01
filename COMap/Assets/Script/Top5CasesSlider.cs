using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Top5CasesSlider : MonoBehaviour {

	public Slider Top5CovidSlider;

	public Text Top5CovidCases;

	public GameObject RioGrande;
	public int month = 1;



	// Use this for initialization
	void Start () {
		Top5CovidCases = GetComponent<Text>();
		ShowSliderValue();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowSliderValue() {
		string sliderMessage = "Top 5 Covid Cases Month " + Top5CovidSlider.value;
		Top5CovidCases.text = sliderMessage;
	}

	public void AdjustMonth(int newMonth) {
		month = (int)Top5CovidSlider.value;


	
		if(month == 1 ) {
			
			if (RioGrande.activeInHierarchy == true) 
				RioGrande.SetActive(false);
			else
				RioGrande.SetActive(true);
			
	 	}
	}
		
}
