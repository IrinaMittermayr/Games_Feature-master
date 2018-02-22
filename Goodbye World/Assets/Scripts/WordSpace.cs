using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpace : MonoBehaviour {
    public GameObject slottedWord = null;
    private MainManager mainManager;

    public virtual void Start () {
        mainManager = GameObject.Find("Main Manager").GetComponent<MainManager>();
	}

    private void OnTriggerEnter(Collider other)
    {
        if (slottedWord == null) {
            if (other.GetComponent<Word>()) {
                slottedWord = other.gameObject;
                other.gameObject.transform.position = transform.position;
                other.gameObject.transform.rotation = transform.rotation;
                other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                mainManager.currentHeldObj = null;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (slottedWord == other.gameObject)
        {
            if (other.GetComponent<Word>())
            {
                slottedWord = null;
            }
        }
    }

    void Update () {
		
	}
}