using UnityEngine;
using System.Collections;

public class MigrantIA : Migrant {

    [SerializeField]
    private LayerMask BoatLayer;

    private float randDomeValue;

    public override void Start()
    {
        base.Start();
        randDomeValue = Random.Range(0, 1);
    }

    public override void Update()
    {
        pressJump = Mathf.RoundToInt(Time.time+ randDomeValue)%2==0;

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, -transform.up);

        if(hitInfo != null) {
            BoatPart downBoat = hitInfo.collider.GetComponent<BoatPart>();
            if(downBoat != null)
            {
                BoatPart leftBoat = downBoat;
                BoatPart rightBoat = downBoat;
                while (leftBoat.leftBoat)
                {
                    leftBoat = leftBoat.leftBoat;
                }
                while (rightBoat.rightBoat)
                {
                    rightBoat = rightBoat.rightBoat;
                }

                float xMillieu = leftBoat.transform.position.x - rightBoat.transform.position.x;
                float direction = xMillieu - transform.position.x;
                this.direction = Mathf.Sign(direction);
            }
        }
        base.Update();
    }
}
