using UnityEngine;
using System.Collections;

public class WaterTrigger : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D collider)
    {
        Migrant migrant = collider.GetComponentInParent<Migrant>();
        if (migrant)
        {
            migrant.Die();
        }
    }

}
