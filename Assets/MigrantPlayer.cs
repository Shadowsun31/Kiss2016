using UnityEngine;
using System.Collections;

public class MigrantPlayer : Migrant {

    [SerializeField]
    private int playerNum;

    [SerializeField]
    private SpriteRenderer arrow;

    private bool isDead = false;

    public float SeuilPushSound = 0.25f;

    public override void Start()
    {
        base.Start();
        arrow.enabled = true;
    }

    public override void Update()
    {
        pressJump = Input.GetButton("Joy" + (playerNum + 1) + "_ButA");
        direction = Input.GetAxisRaw("Joy" + (playerNum + 1) + "_Horizontal");

        base.Update();

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
        if( !isDead )
        {
            isDead = true;
            S_AudioManager.singleton.PlayScream();
        }
          
    }

    void OnCollisionEnter2D( Collision2D collision )
    {

        if( collision.relativeVelocity.magnitude > SeuilPushSound )
            S_AudioManager.singleton.PlayPush();
    }
}
