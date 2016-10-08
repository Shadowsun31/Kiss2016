using UnityEngine;
using System.Collections;

public class S_WavingWater : MonoBehaviour {

    public float m_AmplitudeX = 1.0f;
    public float m_AmplitudeY = 1.0f;
    public float m_OmegaX = 1.0f;
    public float m_OmegaY = 1.0f;

    void Start () {
        m_Transform = GetComponent<Transform>();
	}
	
	void Update () {
        m_Time += Time.deltaTime;

        float x = m_AmplitudeX * Mathf.Cos( m_OmegaX * m_Time );
        float y = Mathf.Abs ( m_AmplitudeY * Mathf.Sin( m_OmegaY * m_Time ) );

        m_Transform.localPosition = new Vector3( x, y, m_Transform.localPosition.z );
    }

    private Transform m_Transform;
    private float m_Time;

}
