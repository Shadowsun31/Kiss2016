using UnityEngine;
using System.Collections;

public class testJump : MonoBehaviour {

    [SerializeField]
    private float jump;

    [SerializeField]
    private float deplacement;


    [SerializeField]
    private new Rigidbody2D rigidbody2D;

    [SerializeField]
    private int player;

	// Use this for initialization
	void Start () {
        //rigidbody2D = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

        if (player == 0)
        {
            if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                rigidbody2D.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rigidbody2D.AddForce(new Vector2(-deplacement, 0), ForceMode2D.Force);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                rigidbody2D.AddForce(new Vector2(deplacement, 0), ForceMode2D.Force);
            }
        }
        if (player == 1)
        {
            if (Input.GetKeyUp(KeyCode.S))
            {
                rigidbody2D.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
            }

            if (Input.GetKey(KeyCode.Q))
            {
                rigidbody2D.AddForce(new Vector2(-deplacement, 0), ForceMode2D.Force);
            }

            if (Input.GetKey(KeyCode.D))
            {
                rigidbody2D.AddForce(new Vector2(deplacement, 0), ForceMode2D.Force);
            }
        }

    }
}
