using UnityEngine;
using System.Collections;

public class WaveSinCos : MonoBehaviour {

    public float speed = 1;
    public float amplitude = 1;
    public float decalage;

    public float facteurOvale = 1;

    private Vector3 basePosition;

	// Use this for initialization
	void Start () {
        basePosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = basePosition + new Vector3(amplitude * Mathf.Sin((Time.time+ decalage) * speed), facteurOvale* amplitude * Mathf.Cos((Time.time + decalage )* speed));
	}
}
