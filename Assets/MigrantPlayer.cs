using UnityEngine;
using System.Collections;

public class MigrantPlayer : Migrant {

    [SerializeField]
    private int playerNum;

    [SerializeField]
    private float jump;

    [SerializeField]
    private float deplacement;

    [SerializeField]
    private SpriteRenderer arrow;


    [SerializeField]
    private new Rigidbody2D rigidbody2D;

    private bool isJumping = false;
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetButton("Joy"+(playerNum+1) + "_ButA"))
        {
            if (!isJumping)
            {
                isJumping = true;
                StartCoroutine(jumpIenum());
            }
        }

        rigidbody2D.AddForce(new Vector2(Input.GetAxisRaw("Joy" + (playerNum + 1) + "_Horizontal")*deplacement, 0), ForceMode2D.Force);

    }

    public IEnumerator jumpIenum()
    {
        rigidbody2D.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        yield return new WaitForSeconds(1);
        isJumping = false;

    }

    public void SetNumPlayer(int playerNum)
    {
        this.playerNum = playerNum;

        if (playerNum == 0)
        {
            arrow.color = Color.green;
        }
        else if (playerNum == 1)
        {
            arrow.color = Color.red;
        }
        else if (playerNum == 2)
        {
            arrow.color = Color.yellow;
        }
        else if (playerNum == 3)
        {
            arrow.color = Color.blue;
        }

    }

    public override void Die()
    {
        base.Die();
        GameManager.singleton.playerDie(playerNum);
    }
}
