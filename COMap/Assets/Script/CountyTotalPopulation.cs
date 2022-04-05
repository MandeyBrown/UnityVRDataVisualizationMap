using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountyTotalPopulation : MonoBehaviour {

	public GameObject ButtonCTP;
	//public GameObject[] NHCounties;
	public GameObject Adams, Alamosa, Arapahoe, Archuleta, Baca, Bent,
	Boulder, Broomfield, Chaffee, Cheyenne, ClearCreek, Conejos, Costilla, Crowley,
	Custer, Delta, Denver, Dolores, Douglas, Eagle, ElPaso, Elbert, Fremont, 
	Garfield, Gilpin, Grand, Gunnison, Hinsdale, Huerfano, Jackson, Jefferson, 
	Kiowa, KitCarson, LaPlata, Lake, Larimer, LasAnimas, Lincoln, Logan,
	Mesa, Mineral, Moffat, Montezuma, Montrose, Morgan, Otero, Ouray, Park, 
	Phillips, Pitkin, Prowers, Pueblo, RioBlanco, RioGrande, Routt, Saguache, 
	SanJuan, SanMiguel, Sedgwick, Summit, Teller, Washington, Weld, Yuma;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	int numCounties = 5;
	//public void CountiesEnabled() {
		//for (var current = 0; current < numCounties; ++current) {
			//NHCounties[current] = transform.GetChild(current).gameObject;
			//if (NHCounties[current].activeInHierarchy == true)
				//NHCounties[current].SetActive(false);
			//else
//				NHCounties[current].SetActive(true);
		//}
		
		//for(int i = 1; i <= numCounties; i++) {
			//if (NHCounties[i].activeInHierarchy == true)
				//NHCounties[i].SetActive(false);
			//else
				//NHCounties[i].SetActive(true);
		//}
	//}

		public void ButtonIndicatorEnabled() {
		if (ButtonCTP.activeInHierarchy == true)
			ButtonCTP.SetActive(false);
		else
			ButtonCTP.SetActive(true);
	}	

	public void AdamsEnabled() {
		if (Adams.activeInHierarchy == true)
			Adams.SetActive(false);
		else
			Adams.SetActive(true);
	}

	public void AlamosaEnabled() {
		if (Alamosa.activeInHierarchy == true)
			Alamosa.SetActive(false);
		else
			Alamosa.SetActive(true);
	}

	public void ArapahoeEnabled() {
		if (Arapahoe.activeInHierarchy == true)
			Arapahoe.SetActive(false);
		else
			Arapahoe.SetActive(true);
	}

	public void ArchuletaEnabled() {
		if (Archuleta.activeInHierarchy == true)
			Archuleta.SetActive(false);
		else
			Archuleta.SetActive(true);
	}

	public void BacaEnabled() {
		if (Baca.activeInHierarchy == true)
			Baca.SetActive(false);
		else
			Baca.SetActive(true);
	}


	public void BentEnabled() {
		if (Bent.activeInHierarchy == true)
			Bent.SetActive(false);
		else
			Bent.SetActive(true);
	}

	public void BoulderEnabled() {
		if (Boulder.activeInHierarchy == true)
			Boulder.SetActive(false);
		else
			Boulder.SetActive(true);
	}

	public void BroomfieldEnabled() {
		if (Broomfield.activeInHierarchy == true)
			Broomfield.SetActive(false);
		else
			Broomfield.SetActive(true);
	}

	public void ChaffeeEnabled() {
		if (Chaffee.activeInHierarchy == true)
			Chaffee.SetActive(false);
		else
			Chaffee.SetActive(true);
	}

	public void CheyenneEnabled() {
		if (Cheyenne.activeInHierarchy == true)
			Cheyenne.SetActive(false);
		else
			Cheyenne.SetActive(true);
	}

	public void ClearCreekEnabled() {
		if (ClearCreek.activeInHierarchy == true)
			ClearCreek.SetActive(false);
		else
			ClearCreek.SetActive(true);
	}

	public void ConejosEnabled() {
		if (Conejos.activeInHierarchy == true)
			Conejos.SetActive(false);
		else
			Conejos.SetActive(true);
	}

	public void CostillaEnabled() {
		if (Costilla.activeInHierarchy == true)
			Costilla.SetActive(false);
		else
			Costilla.SetActive(true);
	}
	public void CrowleyEnabled() {
		if (Crowley.activeInHierarchy == true)
			Crowley.SetActive(false);
		else
			Crowley.SetActive(true);
	}

	public void CusterEnabled() {
		if (Custer.activeInHierarchy == true)
			Custer.SetActive(false);
		else
			Custer.SetActive(true);
	}

	public void DeltaEnabled() {
		if (Delta.activeInHierarchy == true)
			Delta.SetActive(false);
		else
			Delta.SetActive(true);
	}

	public void DenverEnabled() {
		if (Denver.activeInHierarchy == true)
			Denver.SetActive(false);
		else
			Denver.SetActive(true);
	}

	public void DoloresEnabled() {
		if (Dolores.activeInHierarchy == true)
			Dolores.SetActive(false);
		else
			Dolores.SetActive(true);
	}

	public void DouglasEnabled() {
		if (Douglas.activeInHierarchy == true)
			Douglas.SetActive(false);
		else
			Douglas.SetActive(true);
	}

	public void EagleEnabled() {
		if (Eagle.activeInHierarchy == true)
			Eagle.SetActive(false);
		else
			Eagle.SetActive(true);
	}

	public void ElPasoEnabled() {
		if (ElPaso.activeInHierarchy == true)
			ElPaso.SetActive(false);
		else
			ElPaso.SetActive(true);
	}

	public void ElbertEnabled() {
		if (Elbert.activeInHierarchy == true)
			Elbert.SetActive(false);
		else
			Elbert.SetActive(true);
	}

	public void FremontEnabled() {
		if (Fremont.activeInHierarchy == true)
			Fremont.SetActive(false);
		else
			Fremont.SetActive(true);
	}

	public void GarfieldEnabled() {
		if (Garfield.activeInHierarchy == true)
			Garfield.SetActive(false);
		else
			Garfield.SetActive(true);
	}

	public void GilpinEnabled() {
		if (Gilpin.activeInHierarchy == true)
			Gilpin.SetActive(false);
		else
			Gilpin.SetActive(true);
	}

	public void GrandEnabled() {
		if (Grand.activeInHierarchy == true)
			Grand.SetActive(false);
		else
			Grand.SetActive(true);
	}

	public void GunnsonEnabled() {
		if (Gunnison.activeInHierarchy == true)
			Gunnison.SetActive(false);
		else
			Gunnison.SetActive(true);
	}

	public void HinsdaleEnabled() {
		if (Hinsdale.activeInHierarchy == true)
			Hinsdale.SetActive(false);
		else
			Hinsdale.SetActive(true);
	}

	public void HuerfanoEnabled() {
		if (Huerfano.activeInHierarchy == true)
			Huerfano.SetActive(false);
		else
			Huerfano.SetActive(true);
	}

	public void JacksonEnabled() {
		if (Jackson.activeInHierarchy == true)
			Jackson.SetActive(false);
		else
			Jackson.SetActive(true);
	}

	public void JeffersonEnabled() {
		if (Jefferson.activeInHierarchy == true)
			Jefferson.SetActive(false);
		else
			Jefferson.SetActive(true);
	}

	public void KiowaEnabled() {
		if (Kiowa.activeInHierarchy == true)
			Kiowa.SetActive(false);
		else
			Kiowa.SetActive(true);
	}

	public void KitCarsonEnabled() {
		if (KitCarson.activeInHierarchy == true)
			KitCarson.SetActive(false);
		else
			KitCarson.SetActive(true);
	}

	public void LaPlataEnabled() {
		if (LaPlata.activeInHierarchy == true)
			LaPlata.SetActive(false);
		else
			LaPlata.SetActive(true);
	}

	public void LakeEnabled() {
		if (Lake.activeInHierarchy == true)
			Lake.SetActive(false);
		else
			Lake.SetActive(true);
	}

	public void LarimerEnabled() {
		if (Larimer.activeInHierarchy == true)
			Larimer.SetActive(false);
		else
			Larimer.SetActive(true);
	}

	public void LasAnimasEnabled() {
		if (LasAnimas.activeInHierarchy == true)
			LasAnimas.SetActive(false);
		else
			LasAnimas.SetActive(true);
	}

	public void LincolnEnabled() {
		if (Lincoln.activeInHierarchy == true)
			Lincoln.SetActive(false);
		else
			Lincoln.SetActive(true);
	}

	public void LoganEnabled() {
		if (Logan.activeInHierarchy == true)
			Logan.SetActive(false);
		else
			Logan.SetActive(true);
	}

	public void MesaEnabled() {
		if (Mesa.activeInHierarchy == true)
			Mesa.SetActive(false);
		else
			Mesa.SetActive(true);
	}

	public void MineralEnabled() {
		if (Mineral.activeInHierarchy == true)
			Mineral.SetActive(false);
		else
			Mineral.SetActive(true);
	}

	public void MoffatEnabled() {
		if (Moffat.activeInHierarchy == true)
			Moffat.SetActive(false);
		else
			Moffat.SetActive(true);
	}

	public void MontezumaEnabled() {
		if (Montezuma.activeInHierarchy == true)
			Montezuma.SetActive(false);
		else
			Montezuma.SetActive(true);
	}

	public void MontroseEnabled() {
		if (Montrose.activeInHierarchy == true)
			Montrose.SetActive(false);
		else
			Montrose.SetActive(true);
	}

	public void MorganEnabled() {
		if (Morgan.activeInHierarchy == true)
			Morgan.SetActive(false);
		else
			Morgan.SetActive(true);
	}

	public void OteroEnabled() {
		if (Otero.activeInHierarchy == true)
			Otero.SetActive(false);
		else
			Otero.SetActive(true);
	}

	public void OurayEnabled() {
		if (Ouray.activeInHierarchy == true)
			Ouray.SetActive(false);
		else
			Ouray.SetActive(true);
	}

	public void ParkEnabled() {
		if (Park.activeInHierarchy == true)
			Park.SetActive(false);
		else
			Park.SetActive(true);
	}

	public void PhillipsHEnabled() {
		if (Phillips.activeInHierarchy == true)
			Phillips.SetActive(false);
		else
			Phillips.SetActive(true);
	}

	public void PitkinEnabled() {
		if (Pitkin.activeInHierarchy == true)
			Pitkin.SetActive(false);
		else
			Pitkin.SetActive(true);
	}

	public void ProwersEnabled() {
		if (Prowers.activeInHierarchy == true)
			Prowers.SetActive(false);
		else
			Prowers.SetActive(true);
	}

	public void PuebloEnabled() {
		if (Pueblo.activeInHierarchy == true)
			Pueblo.SetActive(false);
		else
			Pueblo.SetActive(true);
	}

	public void RioBlancoEnabled() {
		if (RioBlanco.activeInHierarchy == true)
			RioBlanco.SetActive(false);
		else
			RioBlanco.SetActive(true);
	}

	public void RioGrandeEnabled() {
		if (RioGrande.activeInHierarchy == true)
			RioGrande.SetActive(false);
		else
			RioGrande.SetActive(true);
	}

	public void RouttEnabled() {
		if (Routt.activeInHierarchy == true)
			Routt.SetActive(false);
		else
			Routt.SetActive(true);
	}

	public void SaguacheEnabled() {
		if (Saguache.activeInHierarchy == true)
			Saguache.SetActive(false);
		else
			Saguache.SetActive(true);
	}

	public void SanJuanEnabled() {
		if (SanJuan.activeInHierarchy == true)
			SanJuan.SetActive(false);
		else
			SanJuan.SetActive(true);
	}

	public void SanMiguelEnabled() {
		if (SanMiguel.activeInHierarchy == true)
			SanMiguel.SetActive(false);
		else
			SanMiguel.SetActive(true);
	}

	public void SedgwickEnabled() {
		if (Sedgwick.activeInHierarchy == true)
			Sedgwick.SetActive(false);
		else
			Sedgwick.SetActive(true);
	}

	public void SummitEnabled() {
		if (Summit.activeInHierarchy == true)
			Summit.SetActive(false);
		else
			Summit.SetActive(true);
	}

	public void TellerEnabled() {
		if (Teller.activeInHierarchy == true)
			Teller.SetActive(false);
		else
			Teller.SetActive(true);
	}

	public void WashingtonEnabled() {
		if (Washington.activeInHierarchy == true)
			Washington.SetActive(false);
		else
			Washington.SetActive(true);
	}

	public void WeldEnabled() {
		if (Weld.activeInHierarchy == true)
			Weld.SetActive(false);
		else
			Weld.SetActive(true);
	}

	public void YumaEnabled() {
		if (Yuma.activeInHierarchy == true)
			Yuma.SetActive(false);
		else
			Yuma.SetActive(true);
	}



																				
}

