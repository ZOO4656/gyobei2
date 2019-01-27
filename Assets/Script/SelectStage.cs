using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectStage : MonoBehaviour {

public GameObject desert;
public GameObject sunny;
public GameObject cloudy;

	// Update is called once per frame
	void Update () {
		
	}

	public void selectDesert() {
		desert.SetActive(true);
		sunny.SetActive(false);
		cloudy.SetActive(false);
	}

	public void selectSunny() {
		desert.SetActive(false);
		sunny.SetActive(true);
		cloudy.SetActive(false);
	}

	public void selsectCloudy() {
		desert.SetActive(false);
		sunny.SetActive(false);
		cloudy.SetActive(true);
	}
}
