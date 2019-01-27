using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectStage : MonoBehaviour {

public GameObject desert;
public GameObject forest;

	// Update is called once per frame
	void Update () {
		
	}

	public void selectDesert() {
		desert.SetActive(true);
		forest.SetActive(false);
	}

	public void selectforest() {
		desert.SetActive(false);
		forest.SetActive(true);
	}
}
