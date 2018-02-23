using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpaceWaterfall : WordSpace
{
    public GameObject particleAnchor;
    public Material broken;
    public Material duck;
    public Material water;
    public Material glass;
    public Material fortyfive;
    public Material zero;
    public Material one;
    public Material fifteen;
    public Material wood;
    public Material stone;


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
                case "water":
                    particleAnchor.GetComponent<ParticleSystemRenderer>().material = water;
                    break;
                case "duck":
                    particleAnchor.GetComponent<ParticleSystemRenderer>().material = duck;
                    break;
                case "glass":
                    particleAnchor.GetComponent<ParticleSystemRenderer>().material = glass;
                    break;
                case "wood":
                    particleAnchor.GetComponent<ParticleSystemRenderer>().material = wood;
                    break;
                case "stone":
                    particleAnchor.GetComponent<ParticleSystemRenderer>().material = stone;
                    break;
                case "fortyfive":
                    particleAnchor.GetComponent<ParticleSystemRenderer>().material = fortyfive;
                    break;
                case "fifteen":
                    particleAnchor.GetComponent<ParticleSystemRenderer>().material = fifteen;
                    break;
                case "zero":
                    particleAnchor.GetComponent<ParticleSystemRenderer>().material = zero;
                    break;
                case "one":
                    particleAnchor.GetComponent<ParticleSystemRenderer>().material = one;
                    break;
            }
        }
        else
        {
            particleAnchor.GetComponent<ParticleSystemRenderer>().material = broken;
        }
    }
}
