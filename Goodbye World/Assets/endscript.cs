using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class endscript : MonoBehaviour {


	void onTriggerEnter(){
		onInitnScene ();
	}

	// Use this for initialization
	public void onInitnScene () {
		Application.LoadLevel(1);
	}
}
