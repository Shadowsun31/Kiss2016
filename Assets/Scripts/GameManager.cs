using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static GameManager singleton;

    public CanvasGroup gameOverTitle;
    public string sceneGameOver;

    

    public void Awake()
    {
        singleton = this;
        gameOverTitle.alpha = 0;
        
    }

    public void OnStart()
    {
        StartCoroutine(timerToGameOver());
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
            StartCoroutine(gameOver());
        }
    }

    public IEnumerator timerToGameOver()
    {
        yield return new WaitForSeconds(GameData.singleton.TimeGame);
        StartCoroutine(gameOver());
    }

    public IEnumerator gameOver()
    {
        float startTime = Time.time;
        float normTime = 0;
        while(normTime < 1)
        {
            normTime = (Time.time - startTime) / 1;
            gameOverTitle.alpha = normTime;
            yield return null;
        }
        yield return new WaitForSeconds(2);

        SceneLoader.singleton.changeScene(sceneGameOver);

    }

}
