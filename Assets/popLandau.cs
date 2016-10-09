using UnityEngine;
using System.Collections;

public class popLandau : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (Random.Range(0, 2) == 0)
        {
            gameObject.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
