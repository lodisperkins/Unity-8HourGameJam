using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {

  
    public GameObject target;
    [SerializeField]
    private Vector3 velocity;
    [SerializeField]
    private int max_speed;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == target)
        {
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void seek()
    {

        Vector3 seekforce = target.transform.position - transform.position;
        seekforce = (seekforce.normalized * max_speed) - velocity;
        if (velocity.magnitude > max_speed)
        {
            velocity = velocity.normalized * max_speed;
        }
        transform.position += seekforce * Time.deltaTime;
    }
    
    // Update is called once per frame
    void Update()
    {
        
        seek();
    }
}
