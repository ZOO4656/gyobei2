using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowStageSelect : MonoBehaviour {
//StageSelectWindowを非表示にするにはStageSelectButtunをもう一度押す
public GameObject StageSelectWindow;

//タッチ判定を持っているConfirmTachを制御
public GameObject ConfirmTouch;

//dictionaryが表示されているかどうかを確認
public GameObject dictionaryWindow;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		// if(is_pushStageSelect) {
		// 	//dictionary画面が表示されていれば非表示
		// 	if(dictionaryWindow.activeInHierarchy) {
		// 		dictionaryWindow.SetActive(false);
		// 	}
		// 	//StageSelect画面が表示されていればタッチ判定画面を無効化
			
		// 	StageSelectWindow.SetActive(true);
		// }else {
		// 	ConfirmTach.SetActive(true);
		// 	StageSelectWindow.SetActive(false);

	}

	//StageSelectボタンを押してたかどうか
	public void OnClick() {
			dictionaryWindow.SetActive(false);
		if(StageSelectWindow.activeInHierarchy) {
			ConfirmTouch.SetActive(true);
			StageSelectWindow.SetActive(false);
		}else{
			ConfirmTouch.SetActive(false);
			StageSelectWindow.SetActive(true);
		}
	}
}
