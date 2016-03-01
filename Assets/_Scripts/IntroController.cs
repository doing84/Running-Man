using UnityEngine;
using System.Collections;

public class IntroController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("GameIntro");
        if (Input.GetKeyDown("space"))
        {
            Application.LoadLevel("Main");
        }
        
	}
}
