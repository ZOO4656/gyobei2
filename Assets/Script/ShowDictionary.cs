using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDictionary : MonoBehaviour {
public GameObject showDictionary;
//StageSelectが表示されているかどうかを確認
public GameObject selectWindow;

//タッチ判定を持っているConfirmTachを制御
public GameObject ConfirmTouch;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		// if(is_pushDictionary) {
		// 	if(showStageSelect.activeInHierarchy){
		// 		showStageSelect.SetActive(false);
		// 	}

		// 	showDictionary.SetActive(true);
		// 	Debug.Log("押された");
		// }else{
		// 	showDictionary.SetActive(false);
		// }
	}

	//Dictionaryボタンを押してたかどうか
	public void pushDictionary() {
		selectWindow.SetActive(false);
		if(showDictionary.activeInHierarchy) {
			ConfirmTouch.SetActive(true);
			showDictionary.SetActive(false);
		}else{
			ConfirmTouch.SetActive(false);
			showDictionary.SetActive(true);
		}
	}
}
