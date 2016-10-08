using UnityEngine;
using System.Collections;

public class S_AIController : MonoBehaviour {

    public float m_Speed = 5.0f;
    public float m_JumpForce = 500.0f;

    public Transform m_BorderRight, m_BorderLeft;

    void Start()
    {
        m_Transform = GetComponent<Transform>();
        m_Rb2d = GetComponent<Rigidbody2D>();
    }

    void Update () {

        m_Time += Time.deltaTime;

        m_DistLeft = m_Transform.position.x - m_BorderLeft.position.x;
        m_DistRight = m_BorderRight.position.x - m_Transform.position.x;

        if( m_MoveTimer <= m_Time )
        {
            m_MoveTimer = m_Time + Random.Range(.5f,2.5f);
            //m_MoveX = Random.Range( -1.0f, 1.0f );

            if(m_DistLeft > m_DistRight)
            {
                m_MoveX = Random.Range( -1.0f, 0 );
            }
            else
            {
                m_MoveX = Random.Range( 0, 1.0f );
            }
        }
                

        float XMovement = m_MoveX * m_Speed * Time.deltaTime;

        m_Transform.position = new Vector3( m_Transform.position.x + XMovement, m_Transform.position.y, 0 );

        if( m_IsGrounded && m_Jump )
        {
            Debug.Log( "Jump" );

            m_IsGrounded = false;
            m_Rb2d.AddForce( new Vector2( 0, m_JumpForce ) );
        }
    }

    void OnCollisionEnter2D( Collision2D collision )
    {


        // Collide with Boat
        if( !m_IsGrounded && collision.collider.gameObject.layer == 9 )
        {
            m_Rb2d.velocity = Vector3.zero;
            m_IsGrounded = true;
        }

        // Collide with waves
        if( collision.collider.gameObject.layer == 10 )
        {
            Debug.Log( "Meurt de noyade" );
            Destroy( this.gameObject );
        }

    }

    private Transform m_Transform;
    private Rigidbody2D m_Rb2d;

    private float m_MoveX;
    private float m_Time;

    private float m_MoveTimer;

    private bool m_Jump = false;

    private bool m_IsGrounded = false;

    private float m_DistLeft, m_DistRight;
}
