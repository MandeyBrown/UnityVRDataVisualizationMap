using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Top5CasesSlider : MonoBehaviour {

	public Slider Top5CovidSlider;
	public Text Top5CovidCases;
	public string Top5Date;


	public GameObject M1Elbert;
	public GameObject M1Weld;
	public GameObject M1Denver;
	public GameObject M1Jefferson;
	public GameObject M1Eagle;

	public GameObject M2Elbert;
	public GameObject M2Weld;
	public GameObject M2Denver;
	public GameObject M2Jefferson;
	public GameObject M2Arapahoe;

	public GameObject M3Adams;
	public GameObject M3Weld;
	public GameObject M3Denver;
	public GameObject M3Jefferson;
	public GameObject M3Arapahoe;
	
	public GameObject M4Adams;
	public GameObject M4Weld;
	public GameObject M4Denver;
	public GameObject M4Jefferson;
	public GameObject M4Arapahoe;
		
	public GameObject M5Adams;
	public GameObject M5Weld;
	public GameObject M5Denver;
	public GameObject M5Jefferson;
	public GameObject M5Arapahoe;
	public GameObject M6Adams;
	public GameObject M6Weld;
	public GameObject M6Denver;
	public GameObject M6Jefferson;
	public GameObject M6Arapahoe;
	public GameObject M7Adams;
	public GameObject M7Elbert;
	public GameObject M7Denver;
	public GameObject M7Jefferson;
	public GameObject M7Arapahoe;
	public GameObject M8Adams;
	public GameObject M8Elbert;
	public GameObject M8Denver;
	public GameObject M8Jefferson;
	public GameObject M8Arapahoe;

	public GameObject M9Adams;
	public GameObject M9Elbert;
	public GameObject M9Denver;
	public GameObject M9Jefferson;
	public GameObject M9Arapahoe;

	public GameObject M10Adams;
	public GameObject M10Elbert;
	public GameObject M10Denver;
	public GameObject M10Jefferson;
	public GameObject M10Arapahoe;

	public GameObject M11Adams;
	public GameObject M11Elbert;
	public GameObject M11Denver;
	public GameObject M11Jefferson;
	public GameObject M11Arapahoe;

	public GameObject M12Adams;
	public GameObject M12Elbert;
	public GameObject M12Denver;
	public GameObject M12Jefferson;
	public GameObject M12Arapahoe;

	public GameObject M13Adams;
	public GameObject M13Elbert;
	public GameObject M13Denver;
	public GameObject M13Jefferson;
	public GameObject M13Arapahoe;

	public GameObject M14Adams;
	public GameObject M14Elbert;
	public GameObject M14Denver;
	public GameObject M14Jefferson;
	public GameObject M14Arapahoe;

	public GameObject M15Adams; 
	public GameObject M15Elbert;
	public GameObject M15Denver;
	public GameObject M15Jefferson;
	public GameObject M15Arapahoe;


	// Use this for initialization
	void Start () {


	}

	

	// Update is called once per frame
	void Update () {

		if (Input.GetAxis("Top5SliderUp") >0) {
			Top5CovidSlider.value += 0.10f;
		}	

		if (Input.GetAxis("Top5SliderDown") <0) {
			Top5CovidSlider.value -= 0.10f;
		}

		if((Top5CovidSlider.value > 0.0) && (Top5CovidSlider.value < 1.0)) {
			M1Elbert.SetActive(false);
			M1Weld.SetActive(false);
			M1Denver.SetActive(false);
			M1Jefferson.SetActive(false);
			M1Eagle.SetActive(false);
			Top5Date = "";

	 	}
		
		if((Top5CovidSlider.value > 1.0) && (Top5CovidSlider.value < 2.0)) {
			M1Elbert.SetActive(true);
			M1Weld.SetActive(true);
			M1Denver.SetActive(true);
			M1Jefferson.SetActive(true);
			M1Eagle.SetActive(true);

			M2Elbert.SetActive(false);
			M2Weld.SetActive(false);
			M2Denver.SetActive(false);
			M2Jefferson.SetActive(false);
			M2Arapahoe.SetActive(false);

			Top5Date = "March, 2020";

	 	}

		if((Top5CovidSlider.value > 2.0) && (Top5CovidSlider.value < 3.0)) {
			M1Elbert.SetActive(false);
			M1Weld.SetActive(false);
			M1Denver.SetActive(false);
			M1Jefferson.SetActive(false);
			M1Eagle.SetActive(false);

			M2Elbert.SetActive(true);
			M2Weld.SetActive(true);
			M2Denver.SetActive(true);
			M2Jefferson.SetActive(true);
			M2Arapahoe.SetActive(true);

			M3Adams.SetActive(false);
			M3Weld.SetActive(false);
			M3Denver.SetActive(false);
			M3Jefferson.SetActive(false);
			M3Arapahoe.SetActive(false);

			Top5Date = "April, 2020";

	 	}

		if((Top5CovidSlider.value > 3.0) && (Top5CovidSlider.value < 4.0)) {
			M2Elbert.SetActive(false);
			M2Weld.SetActive(false);
			M2Denver.SetActive(false);
			M2Jefferson.SetActive(false);
			M2Arapahoe.SetActive(false);

			M3Adams.SetActive(true);
			M3Weld.SetActive(true);
			M3Denver.SetActive(true);
			M3Jefferson.SetActive(true);
			M3Arapahoe.SetActive(true);

			M4Adams.SetActive(false);
			M4Weld.SetActive(false);
			M4Denver.SetActive(false);
			M4Jefferson.SetActive(false);
			M4Arapahoe.SetActive(false);			

			Top5Date = "May, 2020";

	 	}

		if((Top5CovidSlider.value > 4.0) && (Top5CovidSlider.value < 5.0)) {
			M3Adams.SetActive(false);
			M3Weld.SetActive(false);
			M3Denver.SetActive(false);
			M3Jefferson.SetActive(false);
			M3Arapahoe.SetActive(false);

			M4Adams.SetActive(true);
			M4Weld.SetActive(true);
			M4Denver.SetActive(true);
			M4Jefferson.SetActive(true);
			M4Arapahoe.SetActive(true);

			M5Adams.SetActive(false);
			M5Weld.SetActive(false);
			M5Denver.SetActive(false);
			M5Jefferson.SetActive(false);
			M5Arapahoe.SetActive(false);			

			Top5Date = "June, 2020";

	 	}

		if((Top5CovidSlider.value > 5.0) && (Top5CovidSlider.value < 6.0)) {
			M4Adams.SetActive(false);
			M4Weld.SetActive(false);
			M4Denver.SetActive(false);
			M4Jefferson.SetActive(false);
			M4Arapahoe.SetActive(false);

			M5Adams.SetActive(true);
			M5Weld.SetActive(true);
			M5Denver.SetActive(true);
			M5Jefferson.SetActive(true);
			M5Arapahoe.SetActive(true);

			M6Adams.SetActive(false);
			M6Weld.SetActive(false);
			M6Denver.SetActive(false);
			M6Jefferson.SetActive(false);
			M6Arapahoe.SetActive(false);			

			Top5Date = "July, 2020";

	 	}

		if((Top5CovidSlider.value > 6.0) && (Top5CovidSlider.value < 7.0)) {
			M5Adams.SetActive(false);
			M5Weld.SetActive(false);
			M5Denver.SetActive(false);
			M5Jefferson.SetActive(false);
			M5Arapahoe.SetActive(false);

			M6Adams.SetActive(true);
			M6Weld.SetActive(true);
			M6Denver.SetActive(true);
			M6Jefferson.SetActive(true);
			M6Arapahoe.SetActive(true);

			M7Adams.SetActive(false);
			M7Elbert.SetActive(false);
			M7Denver.SetActive(false);
			M7Jefferson.SetActive(false);
			M7Arapahoe.SetActive(false);			

			Top5Date = "August, 2020";

	 	}


		if((Top5CovidSlider.value > 7.0) && (Top5CovidSlider.value < 8.0)) {
			M6Adams.SetActive(false);
			M6Weld.SetActive(false);
			M6Denver.SetActive(false);
			M6Jefferson.SetActive(false);
			M6Arapahoe.SetActive(false);

			M7Adams.SetActive(true);
			M7Elbert.SetActive(true);
			M7Denver.SetActive(true);
			M7Jefferson.SetActive(true);
			M7Arapahoe.SetActive(true);

			M8Adams.SetActive(false);
			M8Elbert.SetActive(false);
			M8Denver.SetActive(false);
			M8Jefferson.SetActive(false);
			M8Arapahoe.SetActive(false);			

			Top5Date = "September, 2020";

	 	}
		if((Top5CovidSlider.value > 8.0) && (Top5CovidSlider.value < 9.0)) {
			M7Adams.SetActive(false);
			M7Elbert.SetActive(false);
			M7Denver.SetActive(false);
			M7Jefferson.SetActive(false);
			M7Arapahoe.SetActive(false);

			M8Adams.SetActive(true);
			M8Elbert.SetActive(true);
			M8Denver.SetActive(true);
			M8Jefferson.SetActive(true);
			M8Arapahoe.SetActive(true);

			M9Adams.SetActive(false);
			M9Elbert.SetActive(false);
			M9Denver.SetActive(false);
			M9Jefferson.SetActive(false);
			M9Arapahoe.SetActive(false);			

			Top5Date = "October, 2020";

	 	}

		if((Top5CovidSlider.value > 9.0) && (Top5CovidSlider.value < 10.0)) {
			M8Adams.SetActive(false);
			M8Elbert.SetActive(false);
			M8Denver.SetActive(false);
			M8Jefferson.SetActive(false);
			M8Arapahoe.SetActive(false);

			M9Adams.SetActive(true);
			M9Elbert.SetActive(true);
			M9Denver.SetActive(true);
			M9Jefferson.SetActive(true);
			M9Arapahoe.SetActive(true);

			M10Adams.SetActive(false);
			M10Elbert.SetActive(false);
			M10Denver.SetActive(false);
			M10Jefferson.SetActive(false);
			M10Arapahoe.SetActive(false);			

			Top5Date = "November, 2020";

	 	}

		if((Top5CovidSlider.value > 10.0) && (Top5CovidSlider.value < 11.0)) {
			M9Adams.SetActive(false);
			M9Elbert.SetActive(false);
			M9Denver.SetActive(false);
			M9Jefferson.SetActive(false);
			M9Arapahoe.SetActive(false);

			M10Adams.SetActive(true);
			M10Elbert.SetActive(true);
			M10Denver.SetActive(true);
			M10Jefferson.SetActive(true);
			M10Arapahoe.SetActive(true);

			M11Adams.SetActive(false);
			M11Elbert.SetActive(false);
			M11Denver.SetActive(false);
			M11Jefferson.SetActive(false);
			M11Arapahoe.SetActive(false);			

			Top5Date = "December, 2020";

	 	}

		if((Top5CovidSlider.value > 11.0) && (Top5CovidSlider.value < 12.0)) {
			M10Adams.SetActive(false);
			M10Elbert.SetActive(false);
			M10Denver.SetActive(false);
			M10Jefferson.SetActive(false);
			M10Arapahoe.SetActive(false);

			M11Adams.SetActive(true);
			M11Elbert.SetActive(true);
			M11Denver.SetActive(true);
			M11Jefferson.SetActive(true);
			M11Arapahoe.SetActive(true);

			M12Adams.SetActive(false);
			M12Elbert.SetActive(false);
			M12Denver.SetActive(false);
			M12Jefferson.SetActive(false);
			M12Arapahoe.SetActive(false);			

			Top5Date = "January, 2021";

	 	}

		if((Top5CovidSlider.value > 12.0) && (Top5CovidSlider.value < 13.0)) {
			M11Adams.SetActive(false);
			M11Elbert.SetActive(false);
			M11Denver.SetActive(false);
			M11Jefferson.SetActive(false);
			M11Arapahoe.SetActive(false);

			M12Adams.SetActive(true);
			M12Elbert.SetActive(true);
			M12Denver.SetActive(true);
			M12Jefferson.SetActive(true);
			M12Arapahoe.SetActive(true);

			M13Adams.SetActive(false);
			M13Elbert.SetActive(false);
			M13Denver.SetActive(false);
			M13Jefferson.SetActive(false);
			M13Arapahoe.SetActive(false);			

			Top5Date = "February, 2021";

	 	}

		if((Top5CovidSlider.value > 13.0) && (Top5CovidSlider.value < 14.0)) {
			M12Adams.SetActive(false);
			M12Elbert.SetActive(false);
			M12Denver.SetActive(false);
			M12Jefferson.SetActive(false);
			M12Arapahoe.SetActive(false);

			M13Adams.SetActive(true);
			M13Elbert.SetActive(true);
			M13Denver.SetActive(true);
			M13Jefferson.SetActive(true);
			M13Arapahoe.SetActive(true);

			M14Adams.SetActive(false);
			M14Elbert.SetActive(false);
			M14Denver.SetActive(false);
			M14Jefferson.SetActive(false);
			M14Arapahoe.SetActive(false);			

			Top5Date = "March, 2021";

	 	}
		if((Top5CovidSlider.value > 14.0) && (Top5CovidSlider.value < 15.0)) {
			M13Adams.SetActive(false);
			M13Elbert.SetActive(false);
			M13Denver.SetActive(false);
			M13Jefferson.SetActive(false);
			M13Arapahoe.SetActive(false);

			M14Adams.SetActive(true);
			M14Elbert.SetActive(true);
			M14Denver.SetActive(true);
			M14Jefferson.SetActive(true);
			M14Arapahoe.SetActive(true);

			M15Adams.SetActive(false);
			M15Elbert.SetActive(false);
			M15Denver.SetActive(false);
			M15Jefferson.SetActive(false);
			M15Arapahoe.SetActive(false);			

			Top5Date = "April, 2021";

	 	}

		if((Top5CovidSlider.value > 15.0) && (Top5CovidSlider.value < 16.0)) {
			M14Adams.SetActive(false);
			M14Elbert.SetActive(false);
			M14Denver.SetActive(false);
			M14Jefferson.SetActive(false);
			M14Arapahoe.SetActive(false);

			M15Adams.SetActive(true);
			M15Elbert.SetActive(true);
			M15Denver.SetActive(true);
			M15Jefferson.SetActive(true);
			M15Arapahoe.SetActive(true);

			//M16Adams.SetActive(false);
			//M16Elbert.SetActive(false);
			//M16Denver.SetActive(false);
			//M16Jefferson.SetActive(false);
			//M16Arapahoe.SetActive(false);			

			Top5Date = "May, 2021";

	 	}

		Top5CovidCases.text = "Highest Total Covid Deaths \n" + Top5Date;

	}

		
}
