using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpaceWall: WordSpace {
    public GameObject wallAnchor;
    public GameObject anotherWallAnchor;
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
                    wallAnchor.GetComponent<MeshCollider>().enabled = false;
                    anotherWallAnchor.GetComponent<MeshCollider>().enabled = false;
                    wallAnchor.GetComponent<Renderer>().material = waterMat;
                    anotherWallAnchor.GetComponent<Renderer>().material = waterMat;
                    break;
                case "stone":
                    wallAnchor.GetComponent<MeshCollider>().enabled = true;
                    anotherWallAnchor.GetComponent<MeshCollider>().enabled = true;
                    wallAnchor.GetComponent<Renderer>().material = stoneMat;
                    anotherWallAnchor.GetComponent<Renderer>().material = stoneMat;
                    break;
                case "glass":
                    wallAnchor.GetComponent<MeshCollider>().enabled = true;
                    anotherWallAnchor.GetComponent<MeshCollider>().enabled = true;
                    wallAnchor.GetComponent<Renderer>().material = glassMat;
                    anotherWallAnchor.GetComponent<Renderer>().material = glassMat;
                    break;
                case "wood":
                    wallAnchor.GetComponent<MeshCollider>().enabled = true;
                    anotherWallAnchor.GetComponent<MeshCollider>().enabled = true;
                    wallAnchor.GetComponent<Renderer>().material = woodMat;
                    anotherWallAnchor.GetComponent<Renderer>().material = woodMat;
                    break;
                case "duck":
                    wallAnchor.GetComponent<MeshCollider>().enabled = true;
                    anotherWallAnchor.GetComponent<MeshCollider>().enabled = true;
                    wallAnchor.GetComponent<Renderer>().material = duckMat;
                    anotherWallAnchor.GetComponent<Renderer>().material = duckMat;
                    break;
                case "fall":
                    wallAnchor.GetComponent<MeshCollider>().enabled = true;
                    anotherWallAnchor.GetComponent<MeshCollider>().enabled = true;
                    wallAnchor.GetComponent<Renderer>().material = fallMat;
                    anotherWallAnchor.GetComponent<Renderer>().material = fallMat;
                    break;
                default:
                    wallAnchor.GetComponent<MeshCollider>().enabled = true;
                    anotherWallAnchor.GetComponent<MeshCollider>().enabled = true;
                    wallAnchor.GetComponent<Renderer>().material = corruptedMat;
                    anotherWallAnchor.GetComponent<Renderer>().material = corruptedMat;
                    break;
            }
        } else
        {
            wallAnchor.GetComponent<MeshCollider>().enabled = true;
            anotherWallAnchor.GetComponent<MeshCollider>().enabled = true;
            wallAnchor.GetComponent<Renderer>().material = corruptedMat;
            anotherWallAnchor.GetComponent<Renderer>().material = corruptedMat;
        }
	}
}
