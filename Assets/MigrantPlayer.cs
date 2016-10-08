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

        rigidbody2D.AddForce(new Vector2(Input.GetAxisRaw("Joy" + (playerNum + 1) + "_Horizontal"), 0), ForceMode2D.Force);

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
    }

    public override void Die()
    {
        base.Die();
        GameManager.singleton.playerDie(playerNum);
    }
}
