using UnityEngine;
using System.Collections;

public class S_WavingBoat : MonoBehaviour {

 
    public float m_AmplitudeY = 1.0f;
    public float m_OmegaY = 1.0f;

    public float m_Angle = 5.0f;
    public float m_Period = 5.0f;

    void Start()
    {
        m_Transform = GetComponent<Transform>();
    }

    void Update()
    {
        m_Time += Time.deltaTime;

        float y = Mathf.Abs (m_AmplitudeY * Mathf.Sin( m_OmegaY * m_Time ) );
        m_Transform.localPosition = new Vector3( m_Transform.localPosition.x, y, m_Transform.localPosition.z );

       
        float rotateZ = Mathf.Sin( m_Time / m_Period );
        m_Transform.localRotation = Quaternion.Euler( new Vector3( 0, 0, rotateZ * m_Angle ) );


    }

    private Transform m_Transform;
    private float m_Time;

}
