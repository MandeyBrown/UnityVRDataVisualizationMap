using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Top5CasesSlider : MonoBehaviour {

	public Slider Top5CovidSlider;
	public Text Top5CovidCases;

	public GameObject M1Elbert;
	public GameObject M1Weld;
	public GameObject M1Denver;
	public GameObject M1Jefferson;
	public GameObject M1Eagle;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Top5CovidCases.text = "Top 5 Covid Cases Month " + Top5CovidSlider.value;
		
		if(Top5CovidSlider.value == 1.0) {
			M1Elbert.SetActive(true);
			M1Weld.SetActive(true);
			M1Denver.SetActive(true);
			M1Jefferson.SetActive(true);
			M1Eagle.SetActive(true);

	 	}

		if(Top5CovidSlider.value == 2.0 ) {
			M1Elbert.SetActive(false);
			M1Weld.SetActive(false);
			M1Denver.SetActive(false);
			M1Jefferson.SetActive(false);
			M1Eagle.SetActive(false);

			//M2Elbert.SetActive(true);
			//M2Weld.SetActive(true);
			//M2Denver.SetActive(true);
			//M2Jefferson.SetActive(true);
			//M2Eagle.SetActive(true);

	 	}

		if(Top5CovidSlider.value == 3.0 ) {
			//M12Elbert.SetActive(false);
			//M2Weld.SetActive(false);
			//M2Denver.SetActive(false);
			//M2Jefferson.SetActive(false);
			//M2Eagle.SetActive(false);

			//M3Elbert.SetActive(true);
			//M3Weld.SetActive(true);
			//M3Denver.SetActive(true);
			//M3Jefferson.SetActive(true);
			//M3Eagle.SetActive(true);

	 	}

	}

		
}
