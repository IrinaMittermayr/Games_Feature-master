using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpaceCover : WordSpace {
    public GameObject coverAnchor;

    public override void Start()
    {
        base.Start();

    }
    void Update () {
        if (slottedWord != null)
        {
            switch (slottedWord.GetComponent<Word>().word)
            {
                case "glass":
                    coverAnchor.GetComponent<CoverBreak>().isBreakable = true;
                    break;
                case "stone":
                    coverAnchor.GetComponent<CoverBreak>().isBreakable = false;
                    break;
            }
        } else
        {
            //make bridge broken
        }
	}
}
