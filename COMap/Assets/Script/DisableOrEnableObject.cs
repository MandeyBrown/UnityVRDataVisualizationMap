using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableOrEnableObject : MonoBehaviour {

	public GameObject RioGrande;
	public GameObject Otero;

	public GameObject Alamosa;

	public GameObject Prowers;

	public GameObject Costilla;

	public GameObject Conejos;

	public GameObject Bent;

	public GameObject Crowley;

	public GameObject Pueblo;

	public GameObject LasAnimas;

	public GameObject Saguache;

	public GameObject Morgan;

	public GameObject Montrose;

	public GameObject Sedgwick;

	public GameObject Delta;

	public GameObject Fremont;

	public GameObject Logan;


	public GameObject Baca;

	public GameObject Huerfano;

	public GameObject Adams;

	public GameObject Mesa;

	public GameObject Yuma;

	public GameObject Moffat;

	public GameObject KitCarson;

	public GameObject ButtonSVI;
	public GameObject SocialVulnerabilityButton;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RioGrandeEnabled() {
		if (RioGrande.activeInHierarchy == true)
			RioGrande.SetActive(false);
		else
			RioGrande.SetActive(true);
	}

	public void OteroEnabled() {
		if (Otero.activeInHierarchy == true)
			Otero.SetActive(false);
		else
			Otero.SetActive(true);
	}	

	public void AlamosaEnabled() {
		if (Alamosa.activeInHierarchy == true)
			Alamosa.SetActive(false);
		else
			Alamosa.SetActive(true);
	}	
	public void ProwersEnabled() {
		if (Prowers.activeInHierarchy == true)
			Prowers.SetActive(false);
		else
			Prowers.SetActive(true);
	}
	public void CostillaEnabled() {
		if (Costilla.activeInHierarchy == true)
			Costilla.SetActive(false);
		else
			Costilla.SetActive(true);
	}
	public void ConejosEnabled() {
		if (Conejos.activeInHierarchy == true)
			Conejos.SetActive(false);
		else
			Conejos.SetActive(true);
	}
	public void BentEnabled() {
		if (Bent.activeInHierarchy == true)
			Bent.SetActive(false);
		else
			Bent.SetActive(true);
	}
	public void CrowleyEnabled() {
		if (Crowley.activeInHierarchy == true)
			Crowley.SetActive(false);
		else
			Crowley.SetActive(true);
	}
	public void PuebloEnabled() {
		if (Pueblo.activeInHierarchy == true)
			Pueblo.SetActive(false);
		else
			Pueblo.SetActive(true);
	}
	public void LasAnimasEnabled() {
		if (LasAnimas.activeInHierarchy == true)
			LasAnimas.SetActive(false);
		else
			LasAnimas.SetActive(true);
	}
	public void SaguacheEnabled() {
		if (Saguache.activeInHierarchy == true)
			Saguache.SetActive(false);
		else
			Saguache.SetActive(true);
	}
	public void MorganEnabled() {
		if (Morgan.activeInHierarchy == true)
			Morgan.SetActive(false);
		else
			Morgan.SetActive(true);
	}
	public void MontroseEnabled() {
		if (Montrose.activeInHierarchy == true)
			Montrose.SetActive(false);
		else
			Montrose.SetActive(true);
	}
	public void SedgwickEnabled() {
		if (Sedgwick.activeInHierarchy == true)
			Sedgwick.SetActive(false);
		else
			Sedgwick.SetActive(true);
	}
	public void DeltaEnabled() {
		if (Delta.activeInHierarchy == true)
			Delta.SetActive(false);
		else
			Delta.SetActive(true);
	}
	public void FremontEnabled() {
		if (Fremont.activeInHierarchy == true)
			Fremont.SetActive(false);
		else
			Fremont.SetActive(true);
	}
	public void LoganEnabled() {
		if (Logan.activeInHierarchy == true)
			Logan.SetActive(false);
		else
			Logan.SetActive(true);
	}
	public void BacaEnabled() {
		if (Baca.activeInHierarchy == true)
			Baca.SetActive(false);
		else
			Baca.SetActive(true);
	}
	public void HuerfanoEnabled() {
		if (Huerfano.activeInHierarchy == true)
			Huerfano.SetActive(false);
		else
			Huerfano.SetActive(true);
	}
	public void AdamsEnabled() {
		if (Adams.activeInHierarchy == true)
			Adams.SetActive(false);
		else
			Adams.SetActive(true);
	}
	public void MesaEnabled() {
		if (Mesa.activeInHierarchy == true)
			Mesa.SetActive(false);
		else
			Mesa.SetActive(true);
	}
	public void YumaEnabled() {
		if (Yuma.activeInHierarchy == true)
			Yuma.SetActive(false);
		else
			Yuma.SetActive(true);
	}
	public void MoffatEnabled() {
		if (Moffat.activeInHierarchy == true)
			Moffat.SetActive(false);
		else
			Moffat.SetActive(true);
	}
	public void KitCarsonEnabled() {
		if (KitCarson.activeInHierarchy == true)
			KitCarson.SetActive(false);
		else
			KitCarson.SetActive(true);
	}

	public void ButtonSVIEnabled() {
		if (ButtonSVI.activeInHierarchy == true)
			ButtonSVI.SetActive(false);
		else
			ButtonSVI.SetActive(true);
	}	

	public void SocialVulnerabilityButtonExecute(string trigger) {
		//if (SocialVulnerabilityButton.activeInHierarchy == true)
			//SocialVulnerabilityButton.SetActive(false);
		//else
			//SocialVulnerabilityButton.SetActive(true);
		
        
		var animator = SocialVulnerabilityButton.GetComponent<Animator>();	
		animator.SetTrigger(trigger);

			
	}																				
}
