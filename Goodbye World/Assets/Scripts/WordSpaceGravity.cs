using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpaceGravity : WordSpace {
    public string action;
    public GameObject m_player;
    public GameObject m_bar;


    void Update () {
        if (slottedWord != null)
        {
            switch(slottedWord.GetComponent<Word>().word)
            {
                case "zero":
                    m_player.GetComponent<CharacterMotor>().movement.gravity = 0;
                    m_bar.GetComponent<MeshCollider>().enabled = false;
                    m_bar.GetComponent<MeshRenderer>().enabled = false;
                    break;
                case "fifteen":
                    m_player.GetComponent<CharacterMotor>().movement.gravity = 15;
                    break;
            }
        } else
        {

        }
	}
}
