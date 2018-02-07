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
                    towerAnchor.transform.localScale = new Vector3(1, 1, 1);
                    break;
                case "zero":
                    towerAnchor.transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
                    break;
                case "one":
                    towerAnchor.transform.localScale = new Vector3(0.022f, 0.022f, 0.022f);
                    break;
                case "fifteen":
                    towerAnchor.transform.localScale = new Vector3(0.333f, 0.333f, 0.333f);
                    break;
                default:
                    towerAnchor.transform.localScale = new Vector3(0.076f, 0.07f, 0.0245f);
                    break;
            }
        } else
        {
            towerAnchor.transform.localScale = new Vector3(0.076f, 0.07f, 0.0245f);
        }
	}
}