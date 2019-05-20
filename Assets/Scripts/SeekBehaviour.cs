using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehaviour : MonoBehaviour {

    [SerializeField]
    private GameObject target;
    [SerializeField]
    private Vector3 velocity;
    [SerializeField]
    private int max_speed;
    // Use this for initialization
    void Start()
    {

    }
    void seek()
    {
        
        Vector3 seekforce = target.transform.position - transform.position;
        seekforce = (seekforce.normalized*max_speed) - velocity;
        if (velocity.magnitude > max_speed)
        {
            velocity=velocity.normalized*max_speed;
        }
        transform.position += seekforce*Time.deltaTime;
    }
    // Update is called once per frame
    void Update()
    {
        seek();
    }
}
