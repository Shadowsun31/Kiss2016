using UnityEngine;
using System.Collections;

public class S_CharacterController : MonoBehaviour {

    public float m_Speed = 10.0f;
    public float m_JumpForce = 500.0f;

	void Start () {
        m_Transform = GetComponent<Transform>();
        m_Rb2d = GetComponent<Rigidbody2D>();
	}

	void Update () {
        float XMovement = Input.GetAxis("Horizontal") * m_Speed * Time.deltaTime;
       
        m_Transform.position = new Vector3( m_Transform.position.x + XMovement, m_Transform.position.y , 0);

        if( m_IsGrounded && Input.GetAxis( "Jump" ) > 0 )
        {
            Debug.Log( "Jump" );

            m_IsGrounded = false;
            m_Rb2d.AddForce( new Vector2( 0, m_JumpForce ) );
        }
    }

    void OnCollisionEnter2D( Collision2D collision )
    {
       

        // Collide with Boat
        if( !m_IsGrounded && (  collision.collider.gameObject.layer == 9 ) )
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

    private bool m_IsGrounded = false;
}
