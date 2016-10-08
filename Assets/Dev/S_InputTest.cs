using UnityEngine;
using System.Collections;

public class S_InputTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if( Input.GetButton( "Joy1_ButA" ) )
        {
            Debug.Log( "Joy1 But A" );
        }
        if( Input.GetButton( "Joy1_ButB" ) )
        {
            Debug.Log( "Joy1 But B" );
        }
       

        if( Input.GetButton( "Joy2_ButA" ) )
        {
            Debug.Log( "Joy2 But A" );
        }
        if( Input.GetButton( "Joy2_ButB" ) )
        {
            Debug.Log( "Joy2 But B" );
        }


        if( Input.GetButton( "Joy3_ButA" ) )
        {
            Debug.Log( "Joy3 But A" );
        }
        if( Input.GetButton( "Joy3_ButB" ) )
        {
            Debug.Log( "Joy3 But B" );
        }


        if( Input.GetButton( "Joy4_ButA" ) )
        {
            Debug.Log( "Joy4 But A" );
        }
        if( Input.GetButton( "Joy4_ButB" ) )
        {
            Debug.Log( "Joy4 But B" );
        }

    }
}
