using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class idou : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			SceneManager.LoadScene ("end2");
		}
	}
}