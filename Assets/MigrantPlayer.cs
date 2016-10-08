using UnityEngine;
using System.Collections;

public class MigrantPlayer : Migrant {

    [SerializeField]
    private int playerNum;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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
