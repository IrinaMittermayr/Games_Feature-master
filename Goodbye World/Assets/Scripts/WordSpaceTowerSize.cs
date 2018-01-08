using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpaceTowerSize : WordSpace {
    public GameObject towerAnchor;

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
                    towerAnchor.transform.localScale = new Vector3(1, 1, 1);
                break;
                case "zero":
                    //make bridge 45°
                    towerAnchor.transform.localScale = new Vector3(0.022f, 0.022f, 0.022f);
                    break;
            }
        } else
        {
            towerAnchor.transform.localScale = new Vector3(-0.076f, -0.07f, -0.0245f);
        }
	}
}
