using UnityEngine;
using System.Collections;

public class BoatPart : MonoBehaviour {

    private new Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;

    public float force;

	// Use this for initialization
	void Start () {
        rigidbody2d = GetComponent<Rigidbody2D>();
        boxCollider2d = GetComponent<BoxCollider2D>();
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 Left = -transform.right * transform.lossyScale.x * boxCollider2d.size.x + transform.position;
        Vector3 Right = transform.right * transform.lossyScale.x * boxCollider2d.size.x + transform.position;
	    for(int i =0; i< 10; i++)
        {
            Vector3 position = Vector3.Lerp(Left, Right, ((float)i) / 9);
            if(position.y < 0)
            {
                rigidbody2d.AddForceAtPosition(new Vector2(0, -position.y * force), position,ForceMode2D.Force);
            }
        }
	}
}
