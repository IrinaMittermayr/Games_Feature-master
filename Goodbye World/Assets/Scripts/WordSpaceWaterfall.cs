using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpaceWaterfall : WordSpace {
    public GameObject bridgeAnchor;

    public override void Start()
    {
        base.Start();

    }
    void Update () {
        if (slottedWord != null)
        {
            switch (slottedWord.GetComponent<Word>().word)
            {
                case "fortyfive":
                    //make bridge 0°
                    bridgeAnchor.transform.rotation = Quaternion.Euler(90f, 20f, 0f);
                break;
                case "zero":
                    //make bridge 45°
                    bridgeAnchor.transform.rotation = Quaternion.Euler(45f, 20f, 0f);
                    break;
            }
        } else
        {
            //make bridge broken
        }
	}
}
