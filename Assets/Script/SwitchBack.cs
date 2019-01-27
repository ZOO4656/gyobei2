using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SwitchBack : MonoBehaviour {

	public GameObject back_Desert;
	public GameObject back_SunnyMountain;
	public GameObject back_RainMountain;

	// private int time_id = StartTime % 5;

	// Update is called once per frame
	void Update () {

		//背景の切り替えはStageSelectButtonにより切り替えるため一旦時間経過による変更は停止
		//今後は時間経過による釣れる魚のプール調整や天気を変更する際に使用する。
		// float startTime = Time.time % 5;
		// int startTime_id = (int)startTime;	//floatからint型へキャスト
		// switch(startTime_id) {
		// 	case 0 :
		// 		back_Desert.SetActive(true);
		// 		back_SunnyMountain.SetActive(false);
		// 		back_RainMountain.SetActive(false);
		// 		break;
		// 	case 1:
		// 		back_Desert.SetActive(false);
		// 		back_SunnyMountain.SetActive(true);
		// 		back_RainMountain.SetActive(false);
		// 		break;
		// 	case 2:
		// 		back_Desert.SetActive(false);
		// 		back_SunnyMountain.SetActive(false);
		// 		back_RainMountain.SetActive(true);
		// 		break;
		// }
		// Debug.Log(startTime_id);
	}
}
