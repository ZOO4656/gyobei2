using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterSwitch : MonoBehaviour {

	public bool pushDecision;
	public GameObject CharacterSet1;
	public GameObject CharacterSet2;

	public GameObject fishingFish;

	public bool generateFishLock = true;	//魚の生成時の連続生成防止

	//図鑑登録用のリスト
	public List<int> fishlist;

	// Use this for initialization
	void Start () {
		int[] a = {};
		fishlist = new List<int>(a);
		
	}
	
	// Update is called once per frame
	void Update () {
		if(pushDecision) {
			CharacterSet1.SetActive(false);
			CharacterSet2.SetActive(true);
			// Fish.SetActive(true);
			if(this.generateFishLock) {
				int fishId = Random.Range(0,17);
				//生成元のプレハブをGameObject型で取得
				GameObject originFishingFish = (GameObject)Resources.Load ("Prefab/fish" + fishId);
				//プレハブをもとにインスタンスを生成
				this.fishingFish = Instantiate (originFishingFish, new Vector3(0.0f,0.0f,0.0f), Quaternion.identity);
				this.generateFishLock = false;

				//釣れた魚をリストに格納
				fishlist.Add(fishId);
				int[] f = fishlist.ToArray();
				for(int i = 0; i < f.Length; i++) {
					Debug.Log(f[i]);
				}
			}
		}else {
			CharacterSet1.SetActive(true);
			CharacterSet2.SetActive(false);
			if (this.fishingFish != null) {
				Destroy(this.fishingFish);
			}

			this.generateFishLock = true;
		}

	}

		//画面を押しているかどうか
		public void PushDown() {
			pushDecision = true;
		}
		//画面からタップを離しているかどうか
		public void PushUp() {
			pushDecision = false;
		}
}
