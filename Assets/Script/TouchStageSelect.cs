using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchStageSelect : MonoBehaviour {

public bool pushStageSelect = false;


public GameObject StageSelectWindow;
public GameObject Stage1;
public GameObject Stage2;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(pushStageSelect) {
			StageSelectWindow.SetActive(true);
			Stage1.SetActive(true);
			Stage2.SetActive(true);
		}else {
			StageSelectWindow.SetActive(false);
			Stage1.SetActive(false);
			Stage2.SetActive(false);
		}
	}

	//StageSelectボタンを押してたかどうか
	public void OnClick() {
		if(pushStageSelect == true) {
			pushStageSelect = false;
		}else {
			pushStageSelect = true;
		}
	}
}
