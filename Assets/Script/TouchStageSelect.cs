using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchStageSelect : MonoBehaviour {

public bool pushStageSelect = false;

//StageSelectWindowを非表示にするにはStageSelectButtunをもう一度押す
public GameObject StageSelectWindow;
public GameObject Stage1;

//タッチ判定を持っているConfirmTachを制御
public GameObject ConfirmTach;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(pushStageSelect) {
			ConfirmTach.SetActive(false);
			StageSelectWindow.SetActive(true);
			Stage1.SetActive(true);
		}else {
			ConfirmTach.SetActive(true);
			StageSelectWindow.SetActive(false);
			Stage1.SetActive(false);
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
