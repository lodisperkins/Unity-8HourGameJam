using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotorBehaviour : MonoBehaviour {


	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(1000, 0, 0));
	}
}
