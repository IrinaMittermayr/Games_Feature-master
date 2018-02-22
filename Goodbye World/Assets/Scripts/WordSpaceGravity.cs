using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpaceGravity : WordSpace {
    public string action;
    public GameObject m_player;


    void Update () {
        if (slottedWord != null)
        {
            switch(slottedWord.GetComponent<Word>().word)
            {
                case "zero":
                    m_player.GetComponent<Player.PlayerMovement>().m_gravity = 0;
                    break;
                case "fifteen":
                    m_player.GetComponent<Player.PlayerMovement>().m_gravity = 10;
                    break;
            }
        } else
        {

        }
	}
}
