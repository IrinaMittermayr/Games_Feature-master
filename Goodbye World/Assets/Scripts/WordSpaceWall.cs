using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpaceWall: WordSpace {
    public GameObject wallAnchor;
    public GameObject anotherWallAnchor;

    public override void Start()
    {
        base.Start();

    }
    void Update () {
        if (slottedWord != null)
        {
            switch (slottedWord.GetComponent<Word>().word)
            {
                case "water":
                    //make bridge 0°
                    wallAnchor.GetComponent<MeshCollider>().enabled = false;
                    wallAnchor.GetComponent<MeshRenderer>().enabled = false;
                    anotherWallAnchor.GetComponent<MeshCollider>().enabled = false;
                    anotherWallAnchor.GetComponent<MeshRenderer>().enabled = false;
                    break;
                case "stone":
                    //make bridge 45°
                    wallAnchor.GetComponent<MeshCollider>().enabled = true;
                    wallAnchor.GetComponent<MeshRenderer>().enabled = true;
                    anotherWallAnchor.GetComponent<MeshCollider>().enabled = true;
                    anotherWallAnchor.GetComponent<MeshRenderer>().enabled = true;
                    break;
            }
        } else
        {
            wallAnchor.GetComponent<MeshCollider>().enabled = true;
            wallAnchor.GetComponent<MeshRenderer>().enabled = true;
            anotherWallAnchor.GetComponent<MeshCollider>().enabled = true;
            anotherWallAnchor.GetComponent<MeshRenderer>().enabled = true;
        }
	}
}
