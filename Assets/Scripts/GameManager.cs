using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static GameManager singleton;

    public void Awake()
    {
        singleton = this;
    }

    public void playerDie(int numPlayer)
    {
        GameData.singleton.playerAlive[numPlayer] = false;

        bool StillPlayerAlive = false;
        for(int i = 0;i < GameData.singleton.PlayerMax; i++)
        {
            if(GameData.singleton.playerConnected[i] && GameData.singleton.playerAlive[i])
            {
                StillPlayerAlive = true;
            }
        }
        if (!StillPlayerAlive)
        {

        }
    }

}
