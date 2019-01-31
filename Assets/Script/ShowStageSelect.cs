using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowStageSelect : MonoBehaviour {

//StageSelectボタンを押したかどうか
public bool is_pushStageSelect = false;

//StageSelectWindowを非表示にするにはStageSelectButtunをもう一度押す
public GameObject StageSelectWindow;

//タッチ判定を持っているConfirmTachを制御
public GameObject ConfirmTach;

//dictionaryが表示されているかどうかを確認
public GameObject dictionaryWindow;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(is_pushStageSelect) {
			//dictionary画面が表示されていれば非表示
			if(dictionaryWindow.activeSelf) {
				dictionaryWindow.SetActive(false);
			}

			ConfirmTach.SetActive(false);
			StageSelectWindow.SetActive(true);
		}else {
			ConfirmTach.SetActive(true);
			StageSelectWindow.SetActive(false);
		}


	}

	//StageSelectボタンを押してたかどうか
	public void OnClick() {
		if(is_pushStageSelect == true) {
			is_pushStageSelect = false;
		}else {
			is_pushStageSelect = true;
		}
	}
}
