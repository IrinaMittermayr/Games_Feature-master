using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpaceSpace : WordSpace {
    public string action;
    public GameObject m_player;

    public override void Start()
    {
        base.Start();

    }
    void Update () {
        if (slottedWord != null)
        {
            switch(slottedWord.GetComponent<Word>().word)
            {
                case "jump":
                    m_player.GetComponent<SpaceBarAction>().isJumpEnabled = true;
                    m_player.GetComponent<SpaceBarAction>().isDuckEnabled = false;
                    m_player.GetComponent<SpaceBarAction>().isFallEnabled = false;
                    break;
                case "duck":
                    m_player.GetComponent<SpaceBarAction>().isJumpEnabled = false;
                    m_player.GetComponent<SpaceBarAction>().isDuckEnabled = true;
                    m_player.GetComponent<SpaceBarAction>().isFallEnabled = false;
                    break;
                case "fall":
                    m_player.GetComponent<SpaceBarAction>().isFallEnabled = true;
                    m_player.GetComponent<SpaceBarAction>().isDuckEnabled = false;
                    m_player.GetComponent<SpaceBarAction>().isJumpEnabled = false;
                    break;
            }
        } else
        {
            m_player.GetComponent<SpaceBarAction>().isJumpEnabled = false;
            m_player.GetComponent<SpaceBarAction>().isFallEnabled = false;
            m_player.GetComponent<SpaceBarAction>().isDuckEnabled = false;

        }
	}
}
