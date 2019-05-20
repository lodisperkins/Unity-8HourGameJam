using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PlayerBehaviour : MonoBehaviour {
    public int health;
    public UnityEvent response;
	// Use this for initialization
	void Start () {
        health = 50;
	}
    private void OnTriggerEnter(Collider other)
    {
        health -= 1;
    }
    // Update is called once per frame
    void Update () {
        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal"), 0));
        if (health <= 0)
        {
            response.Invoke();
        }
    }
}
