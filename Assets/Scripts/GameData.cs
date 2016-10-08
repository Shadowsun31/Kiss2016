using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class GameData {

    public static GameData singleton = new GameData();

    public bool[] playerConnected;
    public bool[] playerAlive;
    public int PlayerMax;


    public GameData()
    {
        PlayerMax = 4;
        playerConnected = new bool[4];
        playerAlive = new bool[4];
    }


}
