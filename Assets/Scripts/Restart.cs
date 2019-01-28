using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	public GameObject Snike;
	void Update () {
		if (!Snike) {
			SceneManager.LoadScene( SceneManager.GetActiveScene().name );
		}
	}
}
