using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class GameData {

    public static GameData singleton = new GameData();
    public static int PlayerMax;

    public int[] playerInput;
    public bool[] playerAlive;

    public float[] playerTimeSurvive;
    public int nbrDeadMigrant;
    public int nbrMigrantTotal;

    public Texture2D webCamShot;

    public WebCamTexture camTexture;

    public float TimeGame;

    public int nbrPlayer
    {
        get
        {
            int returnValue = 0;
            for(int i = 0; i < PlayerMax; i++)
            {
                returnValue += playerInput[i] != -1 ? 1 : 0;
            }
            return returnValue;
        }
    }

    public GameData()
    {
        PlayerMax = 4;
        TimeGame = 60;
        playerTimeSurvive = new float[PlayerMax];
        playerInput = new int[PlayerMax];
        playerAlive = new bool[PlayerMax];
        for (int i = 0;i< PlayerMax; i++)
        {
            playerInput[i] = -1;
        }

        playerInput[0] = 0;
        playerAlive[0] = true;
        camTexture = new WebCamTexture();
    }

    public void ResetGameData()
    {
        nbrDeadMigrant = 0;
        nbrMigrantTotal = 0;
        for (int i = 0; i < PlayerMax; i++)
        {
            if(playerInput[i] != -1)
                playerAlive[i] = true;
        }

    }

}
