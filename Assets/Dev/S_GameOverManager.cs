using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class S_GameOverManager : MonoBehaviour
{

    public void Button_Quit()
    {
        Application.Quit();
    }

    public void Button_MainMenu()
    {
        SceneLoader.singleton.changeScene( "MenuScene" );
    }

    public void Button_Restart()
    {
        SceneLoader.singleton.changeScene( "MainScene" );
    }

}
