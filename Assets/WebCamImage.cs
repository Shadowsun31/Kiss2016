using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WebCamImage : MonoBehaviour {

	// Use this for initialization
	void Start () {
        RawImage target = GetComponent<RawImage>();
        target.texture = GameData.singleton.camTexture;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
