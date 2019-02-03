using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSwitch : MonoBehaviour {

	public bool pushDecision;
	public GameObject CharacterSet1;
	public GameObject CharacterSet2;

	//釣れた魚を表示させるObject
	//魚をアタッチしてはならない
	public GameObject fishingFish;

	public GameObject dictionaryWindow;

	public GameObject forestStage;

	//魚の生成時の連続生成防止
	public bool generateFishLock = true;

	//図鑑登録用のリスト
	public List<int> fishlist;

	// Use this for initialization
	void Start () {
		int[] a = {};
		fishlist = new List<int>(a);

		// fish.gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Image/question");
	}

	// Update is called once per frame
	void Update () {
		if(pushDecision) {
			CharacterSet1.SetActive(false);
			CharacterSet2.SetActive(true);
			// Fish.SetActive(true);
			if(this.generateFishLock) {
				int fishId = Random.Range(0,16);
				if(forestStage.activeInHierarchy) {
					fishId = 16;
				}

				//生成元のプレハブをGameObject型で取得
				GameObject originFishingFish = (GameObject)Resources.Load ("Prefab/fish" + fishId);
				//プレハブをもとにインスタンスを生成
				this.fishingFish = Instantiate (originFishingFish, new Vector3(0.0f,0.0f,0.0f), Quaternion.identity);
				this.generateFishLock = false;

				//釣れた魚をリストに格納
				fishlist.Add(fishId);
				int[] fishListIds = fishlist.ToArray();


				Transform[] fishs = dictionaryWindow.GetComponentsInChildren<Transform>();
				foreach(Transform fish in fishs) {
					Debug.Log(fish.gameObject.name);
					//ヒエラルキー中のnullとSpriteが無いデータ以外の画像をハテナにする
					if(fish.gameObject.GetComponent<Image>() != null && fish.gameObject.GetComponent<Image>().sprite != null) {
						//fishListIds配列の中身を変数fishIdに一つずつ格納
						foreach(int fId in fishListIds) {
							//魚の名前とIDが一致したら、図鑑の画像を差し替える
							if(fish.gameObject.name == "Chara" + fId) {
								fish.gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Image/fish" + fId);
							}
						}
					}
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
