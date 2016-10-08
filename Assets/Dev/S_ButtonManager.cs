using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class S_ButtonManager : MonoBehaviour
{

    public GameObject m_MainMenu, m_SelectPlayer, m_Credits;

    public Button m_StartGameButton;

    #region MainMenu

    public void Menu_Start()
    {
        m_SelectPlayer.SetActive( true );
        m_MainMenu.SetActive( false );
    }

    public void Menu_Credits()
    {
        m_Credits.SetActive( true );
        m_MainMenu.SetActive( false );
    }

    public void Menu_Quit()
    {
        Application.Quit();
    }

    #endregion

  

    void Update()
    {
        if( m_SelectPlayer.activeInHierarchy )
        {
            if( Input.GetButtonDown( "Cancel" ) )
            {
                m_SelectPlayer.SetActive( false );
                m_MainMenu.SetActive( true );
                m_StartGameButton.Select();

            }

            if( Input.GetButtonDown( "Submit" ) )
            {
                // Add a player
            }
        }

        if( m_Credits.activeInHierarchy )
        {
            if( Input.GetButtonDown( "Cancel" ) )
            {
                m_Credits.SetActive( false );
                m_MainMenu.SetActive( true );
                m_StartGameButton.Select();
                           
            }
        }
      
        

    }


}
