using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpaceLake : WordSpace
{
    public GameObject lakeAnchor;
    public Mesh stoneMesh, woodMesh, waterMesh, glassMesh, duckMesh, fallMesh, corruptedMesh;
    public Material waterMat, stoneMat, glassMat, woodMat, duckMat, fallMat, corruptedMat;

    public override void Start()
    {
        base.Start();
    }
    void Update()
    {
        if (slottedWord != null)
        {
            switch (slottedWord.GetComponent<Word>().word)
            {
                case "stone":
                    lakeAnchor.GetComponent<MeshFilter>().mesh = stoneMesh;
                    lakeAnchor.GetComponent<Renderer>().material = stoneMat;
                    break;
                case "wood":
                    lakeAnchor.GetComponent<MeshFilter>().mesh = woodMesh;
                    lakeAnchor.GetComponent<Renderer>().material = woodMat;
                    break;
                case "water":
                    lakeAnchor.GetComponent<MeshFilter>().mesh = waterMesh;
                    lakeAnchor.GetComponent<Renderer>().material = waterMat;
                    break;
                case "glass":
                    lakeAnchor.GetComponent<MeshFilter>().mesh = glassMesh;
                    lakeAnchor.GetComponent<Renderer>().material = glassMat;
                    break;
                case "duck":
                    lakeAnchor.GetComponent<MeshFilter>().mesh = duckMesh;
                    lakeAnchor.GetComponent<Renderer>().material = duckMat;
                    break;
                case "fall":
                    lakeAnchor.GetComponent<MeshFilter>().mesh = fallMesh;
                    lakeAnchor.GetComponent<Renderer>().material = fallMat;
                    break;
                default:
                    lakeAnchor.GetComponent<MeshFilter>().mesh = corruptedMesh;
                    lakeAnchor.GetComponent<Renderer>().material = corruptedMat;
                    break;
            }
        }
        else
        {
            lakeAnchor.GetComponent<MeshFilter>().mesh = corruptedMesh;
            lakeAnchor.GetComponent<Renderer>().material = corruptedMat;
        }
    }
}