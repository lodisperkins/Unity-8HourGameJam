using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatanaBehaviour : MonoBehaviour {
    Transform origin;
    public float timer;
    public float rotVal;
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }

    private void Start()
    {
        origin = transform;
    }
    // Update is called once per frame
    void Update () {
        
		if(Input.GetButtonDown("Fire1"))
        {
            transform.GetChild(0).GetComponent<MeshCollider>().enabled = true;
            transform.GetChild(0).GetComponent<MeshCollider>().isTrigger = true;
            transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
            GetComponent<Animator>().SetTrigger("swingtrigger");
        }
	}
}
