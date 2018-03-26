using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updatescript : MonoBehaviour {


	RectTransform scrollPos;
	public float positionY = 0;
	public bool Scene01 = false;
	public bool Scene02 = false;
	public bool Scene03 = false;
	public bool Scene04 = false;

	public GameObject[] Scenes;
	public int position;
	// Use this for initialization
	void Start () {
		scrollPos = GameObject.Find("MainPanelContainer").GetComponent<RectTransform>();

	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (scrollPos.offsetMin.y);
		//Debug.Log (scrollPos.offsetMax.y);
		positionY = scrollPos.offsetMax.y;
//		Debug.Log (positionY);
	
		if ((positionY >= 4090) && (positionY <= 6470)) {
			Scene01 = true;
			Scenes [0].SetActive (true);

			Debug.Log("scene01 is " + Scene01);
		} else {
			Scene01 = false;
			Debug.Log("scene01 is" + Scene01);
			Scenes [0].SetActive (false);
		}

		if ((positionY >= 6480) && (positionY <= 8930)) {
			Scene02 = true;
			Debug.Log("scene02 is " + Scene02);
			Scenes [1].SetActive (true);
		}else {
			Scene02 = false;
			Debug.Log("scene02 is" + Scene02);
			Scenes [1].SetActive (false);
		}

		if ((positionY >= 8940) && (positionY <= 11400)) {
			Scene03 = true;
			Debug.Log("scene03 is" + Scene03);
			Scenes [2].SetActive (true);
		}
		else {
			Scene03 = false;
			Debug.Log("scene03 is" + Scene03);
			Scenes [2].SetActive (false);
		}

		if ((positionY >= 11430)) {
			Scene04 = true;
			Debug.Log("scene04 is" + Scene04);
			Scenes [3].SetActive (true);
		}else {
			Scene04 = false;
			Debug.Log("scene04 is" + Scene04);
			Scenes [3].SetActive (false);
		}
	}
}
