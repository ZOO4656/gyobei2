using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDictionary : MonoBehaviour {


private bool is_pushDictionary = false;

public GameObject showDictionary;
//StageSelectが表示されているかどうかを確認
public GameObject selectWindow;

// selectWindow.GetComponent<ShowStageSelect>().is_pushStageSelect;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(is_pushDictionary) {
			if(selectWindow.activeSelf){
				selectWindow.SetActive(false);
			}

			showDictionary.SetActive(true);
		}else{
			showDictionary.SetActive(false);
		}
	}

	//Dictionaryボタンを押してたかどうか
	public void pushDictionary() {
		if(is_pushDictionary == true) {
			is_pushDictionary = false;
		}else{
			is_pushDictionary = true;
		}
	}
}
