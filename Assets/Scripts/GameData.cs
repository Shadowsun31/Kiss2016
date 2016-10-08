using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class GameData {

    public static GameData singleton = new GameData();

    public bool[] playerConnected;
    public bool[] playerAlive;
    public int PlayerMax;

    public float TimeGame;

    public GameData()
    {
        TimeGame = 60;
        PlayerMax = 4;
        playerConnected = new bool[4];
        playerAlive = new bool[4];

        playerAlive[0] = true;
        playerConnected[0] = true;
    }


}
