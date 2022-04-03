using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Top5CasesSlider : MonoBehaviour {

	// Slider object
	public Slider Top5CovidSlider;
	// Text object to display date on screen
	public Text Top5CovidText;

	// String to hold current date
	public string Top5Date;

	// NOTE - I'm still working on creating the maps to more efficiently code
	// I know what I have right now is obnoxious :) 

	// Top 5 Counties for Month 1 / March, 2020
	public GameObject M1Elbert, M1Weld, M1Denver, M1Jefferson, M1Eagle;



	// Top 5 Counties for Month 2 / April, 2020
	public GameObject M2Elbert, M2Weld, M2Denver, M2Jefferson, M2Arapahoe;


	// Top 5 Counties for Month 3 / May, 2020
	public GameObject M3Adams, M3Weld, M3Denver, M3Jefferson, M3Arapahoe;


	// Top 5 Counties for Month 4 / June, 2020
	public GameObject M4Adams, M4Weld, M4Denver, M4Jefferson, M4Arapahoe;

	// Top 5 Counties for Month 5 / July, 2020	
	public GameObject M5Adams, M5Weld, M5Denver, M5Jefferson, M5Arapahoe;

	// Top 5 Counties for Month 6 / August, 2020
	public GameObject M6Adams, M6Weld, M6Denver, M6Jefferson, M6Arapahoe;

	// Top 5 Counties for Month 7 / September, 2020
	public GameObject M7Adams, M7Elbert, M7Denver, M7Jefferson, M7Arapahoe;

	// Top 5 Counties for Month 8 / October, 2020
	public GameObject M8Adams, M8Elbert, M8Denver, M8Jefferson, M8Arapahoe;

	// Top 5 Counties for Month 9 / November, 2020
	public GameObject M9Adams, M9Elbert, M9Denver, M9Jefferson, M9Arapahoe;

	// Top 5 Counties for Month 10 / December, 2020
	public GameObject M10Adams, M10Elbert, M10Denver, M10Jefferson, M10Arapahoe;

	// Top 5 Counties for Month 11 / January, 2021
	public GameObject M11Adams, M11Elbert, M11Denver, M11Jefferson, M11Arapahoe;

	// Top 5 Counties for Month 12 / February, 2021
	public GameObject M12Adams, M12Elbert, M12Denver, M12Jefferson, M12Arapahoe;

	// Top 5 Counties for Month 13 / March, 2021
	public GameObject M13Adams, M13Elbert, M13Denver, M13Jefferson, M13Arapahoe;

	// Top 5 Counties for Month 14 / April, 2021
	public GameObject M14Adams, M14Elbert, M14Denver, M14Jefferson, M14Arapahoe;

	// Top 5 Counties for Month 15 / May, 2021
	public GameObject M15Adams, M15Elbert, M15Denver, M15Jefferson, M15Arapahoe;

	// Top 5 Counties for Month 16 / June, 2021
	public GameObject M16Adams, M16Elbert, M16Denver, M16Jefferson, M16Arapahoe;

	// Top 5 Counties for Month 17 / July, 2021
	public GameObject M17Adams, M17Elbert, M17Denver, M17Jefferson, M17Arapahoe;

	// Top 5 Counties for Month 18 / August, 2021
	public GameObject M18Adams, M18Elbert, M18Denver, M18Jefferson, M18Arapahoe;

	// Top 5 Counties for Month 19 / September, 2021
	public GameObject M19Adams, M19Elbert, M19Denver, M19Jefferson, M19Arapahoe;

	// Top 5 Counties for Month 20 / October, 2021
	public GameObject M20Adams, M20Elbert, M20Denver, M20Jefferson, M20Arapahoe;

	// Top 5 Counties for Month 21 / November, 2021
	public GameObject M21Adams, M21Elbert, M21Denver, M21Jefferson, M21Arapahoe;

	// Top 5 Counties for Month 22 / December, 2021
	public GameObject M22Adams, M22Elbert, M22Denver, M22Jefferson, M22Arapahoe;

	// Top 5 Counties for Month 23 / January, 2022
	public GameObject M23Adams, M23Elbert, M23Denver, M23Jefferson, M23Arapahoe;



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

			M16Adams.SetActive(false);
			M16Elbert.SetActive(false);
			M16Denver.SetActive(false);
			M16Jefferson.SetActive(false);
			M16Arapahoe.SetActive(false);			

			Top5Date = "May, 2021";

	 	}

		 if((Top5CovidSlider.value > 16.0) && (Top5CovidSlider.value < 17.0)) {
			M15Adams.SetActive(false);
			M15Elbert.SetActive(false);
			M15Denver.SetActive(false);
			M15Jefferson.SetActive(false);
			M15Arapahoe.SetActive(false);

			M16Adams.SetActive(true);
			M16Elbert.SetActive(true);
			M16Denver.SetActive(true);
			M16Jefferson.SetActive(true);
			M16Arapahoe.SetActive(true);

			M17Adams.SetActive(false);
			M17Elbert.SetActive(false);
			M17Denver.SetActive(false);
			M17Jefferson.SetActive(false);
			M17Arapahoe.SetActive(false);			

			Top5Date = "June, 2021";

	 	}

		 if((Top5CovidSlider.value > 17.0) && (Top5CovidSlider.value < 18.0)) {
			M16Adams.SetActive(false);
			M16Elbert.SetActive(false);
			M16Denver.SetActive(false);
			M16Jefferson.SetActive(false);
			M16Arapahoe.SetActive(false);

			M17Adams.SetActive(true);
			M17Elbert.SetActive(true);
			M17Denver.SetActive(true);
			M17Jefferson.SetActive(true);
			M17Arapahoe.SetActive(true);

			M18Adams.SetActive(false);
			M18Elbert.SetActive(false);
			M18Denver.SetActive(false);
			M18Jefferson.SetActive(false);
			M18Arapahoe.SetActive(false);			

			Top5Date = "July, 2021";

	 	}

		 if((Top5CovidSlider.value > 18.0) && (Top5CovidSlider.value < 19.0)) {
			M17Adams.SetActive(false);
			M17Elbert.SetActive(false);
			M17Denver.SetActive(false);
			M17Jefferson.SetActive(false);
			M17Arapahoe.SetActive(false);

			M18Adams.SetActive(true);
			M18Elbert.SetActive(true);
			M18Denver.SetActive(true);
			M18Jefferson.SetActive(true);
			M18Arapahoe.SetActive(true);

			M19Adams.SetActive(false);
			M19Elbert.SetActive(false);
			M19Denver.SetActive(false);
			M19Jefferson.SetActive(false);
			M19Arapahoe.SetActive(false);			

			Top5Date = "August, 2021";

	 	}

		 if((Top5CovidSlider.value > 19.0) && (Top5CovidSlider.value < 20.0)) {
			M18Adams.SetActive(false);
			M18Elbert.SetActive(false);
			M18Denver.SetActive(false);
			M18Jefferson.SetActive(false);
			M18Arapahoe.SetActive(false);

			M19Adams.SetActive(true);
			M19Elbert.SetActive(true);
			M19Denver.SetActive(true);
			M19Jefferson.SetActive(true);
			M19Arapahoe.SetActive(true);

			M20Adams.SetActive(false);
			M20Elbert.SetActive(false);
			M20Denver.SetActive(false);
			M20Jefferson.SetActive(false);
			M20Arapahoe.SetActive(false);			

			Top5Date = "September, 2021";

	 	}

		 if((Top5CovidSlider.value > 20.0) && (Top5CovidSlider.value < 21.0)) {
			M19Adams.SetActive(false);
			M19Elbert.SetActive(false);
			M19Denver.SetActive(false);
			M19Jefferson.SetActive(false);
			M19Arapahoe.SetActive(false);

			M20Adams.SetActive(true);
			M20Elbert.SetActive(true);
			M20Denver.SetActive(true);
			M20Jefferson.SetActive(true);
			M20Arapahoe.SetActive(true);

			M21Adams.SetActive(false);
			M21Elbert.SetActive(false);
			M21Denver.SetActive(false);
			M21Jefferson.SetActive(false);
			M21Arapahoe.SetActive(false);			

			Top5Date = "October, 2021";

	 	}

		 if((Top5CovidSlider.value > 21.0) && (Top5CovidSlider.value < 22.0)) {
			M20Adams.SetActive(false);
			M20Elbert.SetActive(false);
			M20Denver.SetActive(false);
			M20Jefferson.SetActive(false);
			M20Arapahoe.SetActive(false);

			M21Adams.SetActive(true);
			M21Elbert.SetActive(true);
			M21Denver.SetActive(true);
			M21Jefferson.SetActive(true);
			M21Arapahoe.SetActive(true);

			M22Adams.SetActive(false);
			M22Elbert.SetActive(false);
			M22Denver.SetActive(false);
			M22Jefferson.SetActive(false);
			M22Arapahoe.SetActive(false);			

			Top5Date = "November, 2021";

	 	}

		 if((Top5CovidSlider.value > 22.0) && (Top5CovidSlider.value < 23.0)) {
			M21Adams.SetActive(false);
			M21Elbert.SetActive(false);
			M21Denver.SetActive(false);
			M21Jefferson.SetActive(false);
			M21Arapahoe.SetActive(false);

			M22Adams.SetActive(true);
			M22Elbert.SetActive(true);
			M22Denver.SetActive(true);
			M22Jefferson.SetActive(true);
			M22Arapahoe.SetActive(true);

			M23Adams.SetActive(false);
			M23Elbert.SetActive(false);
			M23Denver.SetActive(false);
			M23Jefferson.SetActive(false);
			M23Arapahoe.SetActive(false);			

			Top5Date = "December, 2021";

	 	}

		 if(Top5CovidSlider.value == 23.0) {
			M22Adams.SetActive(false);
			M22Elbert.SetActive(false);
			M22Denver.SetActive(false);
			M22Jefferson.SetActive(false);
			M22Arapahoe.SetActive(false);

			M23Adams.SetActive(true);
			M23Elbert.SetActive(true);
			M23Denver.SetActive(true);
			M23Jefferson.SetActive(true);
			M23Arapahoe.SetActive(true);
		

			Top5Date = "January, 2022";

	 	}

		Top5CovidText.text = "Highest Total Covid Deaths \n" + Top5Date;

	}

		
}
