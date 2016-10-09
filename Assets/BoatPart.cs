using UnityEngine;
using System.Collections;

public class BoatPart : MonoBehaviour {

    public BoatPart leftBoat;
    public BoatPart rightBoat;

    private new Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;

    private FixedJoint2D joint;

    public float force;
    public float forceWave;

    public float minTimeToBreak = 10;
    public float maxTimeToBreak = 180;

    private float timeToBreak;

    private float startTime;

	// Use this for initialization
	void Start () {
        startTime = Time.time;
        timeToBreak = Random.Range(minTimeToBreak, maxTimeToBreak) + startTime;
        rigidbody2d = GetComponent<Rigidbody2D>();
        boxCollider2d = GetComponent<BoxCollider2D>();
        joint = GetComponent<FixedJoint2D>();
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

            float wavefactor = (Mathf.Sin(Mathf.PI * position.x / 14 + Time.time) + Mathf.Sin(Mathf.PI * position.y / 7 - Time.time))*(Time.time - startTime)/GameData.singleton.TimeGame;
            rigidbody2d.AddForceAtPosition(new Vector2(0, wavefactor * forceWave), position, ForceMode2D.Force);
        }

        if(Time.time > timeToBreak)
        {
            joint.enabled = false;
            joint.connectedBody = null;
            if (rightBoat)
            {
                rightBoat.leftBoat = null;
                if (!rightBoat.rightBoat && !rightBoat.leftBoat)
                    rightBoat.force = 0;
            }
            rightBoat = null;

            if (!rightBoat && !leftBoat)
                force = 0;
        }
	}
}
