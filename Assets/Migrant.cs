using UnityEngine;
using System.Collections;

public class Migrant : MonoBehaviour {

    public virtual void Start()
    {
    }

    public virtual void Die()
    {
        GameData.singleton.nbrDeadMigrant++;
    }
}
