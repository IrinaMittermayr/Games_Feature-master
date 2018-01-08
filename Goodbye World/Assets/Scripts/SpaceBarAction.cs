using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceBarAction : MonoBehaviour {

    public bool isDuckEnabled;
    public bool isFallEnabled;

	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            if (isDuckEnabled)
            {
                transform.localScale = new Vector3(1, 0.5f, 1);
            }
            else if(isFallEnabled)
            {
                GetComponent<CharacterMotor>().movement.isAbleToFall = true;
            }
        }
        else
        {
            if (Input.GetKeyUp(KeyCode.Space) && isDuckEnabled)
            {
                transform.position += new Vector3(0, 0.5f, 0);
            }
            transform.localScale = new Vector3(1, 1, 1);
            GetComponent<CharacterMotor>().movement.isAbleToFall = false;
        }


    }
}
