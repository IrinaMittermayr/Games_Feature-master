using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpaceBridge : WordSpace {
    public GameObject bridgeAnchor;

    public override void Start()
    {
        base.Start();

    }
    void Update () {
        if (slottedWord != null)
        {
            switch (slottedWord.name)
            {
                case "WordDum":
                    //make bridge 0°
                    bridgeAnchor.transform.rotation = Quaternion.Euler(0f,0f,45f);
                break;
                case "WordBloed":
                    //make bridge 45°
                    bridgeAnchor.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    break;
            }
        } else
        {
            //make bridge broken
        }
	}
}
