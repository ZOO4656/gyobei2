using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterSwitch : MonoBehaviour {

	public bool pushDecision;
	public GameObject CharacterSet1;
	public GameObject CharacterSet2;
	public GameObject Fish;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(pushDecision){
			CharacterSet1.SetActive(false);
			CharacterSet2.SetActive(true);
			Fish.SetActive(true);
		}else {
			CharacterSet1.SetActive(true);
			CharacterSet2.SetActive(false);
			Fish.SetActive(false);
		}

	}
		public void PushDown() {
			pushDecision = true;
		}
		public void PushUp() {
			pushDecision = false;
		}
}
