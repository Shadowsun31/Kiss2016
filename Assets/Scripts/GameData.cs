using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class GameData {

    public static GameData singleton = new GameData();
    public static int PlayerMax = 4;

    public int[] playerInput;
    public bool[] playerAlive;

    public float TimeGame;

    public GameData()
    {
        TimeGame = 60;
        playerInput = new int[PlayerMax];
        playerAlive = new bool[PlayerMax];
        for (int i = 0;i< PlayerMax; i++)
        {
            playerInput[i] = -1;
        }

        playerAlive[0] = true;
        playerInput[0] = 0;
    }


}
