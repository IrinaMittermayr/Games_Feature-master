using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpaceCover : WordSpace {
    public GameObject coverAnchor;
    public Material waterMat, stoneMat, glassMat, woodMat, duckMat, fallMat, corruptedMat;

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
                    coverAnchor.GetComponent<CoverBreak>().isBreakable = false;
                    coverAnchor.GetComponent<MeshCollider>().enabled = false;
                    coverAnchor.GetComponent<Renderer>().material = waterMat;
                    break;
                case "stone":
                    coverAnchor.GetComponent<CoverBreak>().isBreakable = false;
                    coverAnchor.GetComponent<MeshCollider>().enabled = true;
                    coverAnchor.GetComponent<Renderer>().material = stoneMat;
                    break;
                case "glass":
                    coverAnchor.GetComponent<CoverBreak>().isBreakable = true;
                    coverAnchor.GetComponent<MeshCollider>().enabled = true;
                    coverAnchor.GetComponent<Renderer>().material = glassMat;
                    break;
                case "wood":
                    coverAnchor.GetComponent<CoverBreak>().isBreakable = false;
                    coverAnchor.GetComponent<MeshCollider>().enabled = true;
                    coverAnchor.GetComponent<Renderer>().material = woodMat;
                    break;
                case "duck":
                    coverAnchor.GetComponent<CoverBreak>().isBreakable = false;
                    coverAnchor.GetComponent<MeshCollider>().enabled = true;
                    coverAnchor.GetComponent<Renderer>().material = duckMat;
                    break;
                case "fall":
                    coverAnchor.GetComponent<CoverBreak>().isBreakable = false;
                    coverAnchor.GetComponent<MeshCollider>().enabled = true;
                    coverAnchor.GetComponent<Renderer>().material = fallMat;
                    break;
                default:
                    coverAnchor.GetComponent<CoverBreak>().isBreakable = false;
                    coverAnchor.GetComponent<MeshCollider>().enabled = true;
                    coverAnchor.GetComponent<Renderer>().material = corruptedMat;
                    break;

            }
        } else
        {
            coverAnchor.GetComponent<CoverBreak>().isBreakable = false;
            coverAnchor.GetComponent<MeshCollider>().enabled = true;
            coverAnchor.GetComponent<Renderer>().material = corruptedMat;
        }
	}
}
