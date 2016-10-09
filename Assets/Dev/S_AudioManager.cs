using UnityEngine;
using System.Collections;

public class S_AudioManager : MonoBehaviour {

    public static S_AudioManager singleton;

    public AudioSource[] m_Screams, m_Ploufs, m_Pushs;

    void Awake()
    {
        singleton = this;
    }

	public void PlayScream()
    {
        m_Screams[Random.Range( 0, m_Screams.Length )].Play();
    }

    public void PlayPlouf()
    {
        m_Ploufs[ Random.Range( 0, m_Ploufs.Length ) ].Play();
    }

    public void PlayPush()
    {
        m_Pushs[ Random.Range( 0, m_Pushs.Length ) ].Play();
    }

}
