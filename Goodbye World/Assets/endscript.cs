using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class endscript : MonoBehaviour {


	void OnTriggerEnter(Collider other){
        if(other.tag=="Player")
		    onInitnScene ();
	}

	// Use this for initialization
	public void onInitnScene () {
        SceneManager.LoadScene(2);
	}
}
