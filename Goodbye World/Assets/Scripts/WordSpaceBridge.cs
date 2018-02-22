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
            switch (slottedWord.GetComponent<Word>().word)
            {
                case "fortyfive":
                    //make bridge 0°
                    bridgeAnchor.transform.rotation = Quaternion.Euler(180f, 20f, 180f);
                    break;
                case "zero":
                    //make bridge 45°
                    bridgeAnchor.transform.rotation = Quaternion.Euler(225f, 20f, 180f);
                    break;
                case "one":
                    //make bridge 1°
                    bridgeAnchor.transform.rotation = Quaternion.Euler(226f, 20f, 180f);
                    break;
                case "fifteen":
                    //make bridge 15°
                    bridgeAnchor.transform.rotation = Quaternion.Euler(240f, 20f, 180f);
                    break;
            }
        } else
        {
            bridgeAnchor.transform.rotation = Quaternion.Euler(0f, 100f, -190f);
        }
	}
}
