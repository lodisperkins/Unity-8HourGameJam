using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class SpawnBehaviour : MonoBehaviour
{
    [SerializeField]
    private int Spawn_Limit;
    private int spawncount;
    public GameObject player;
    [SerializeField]
    private GameObject Enemy;
    [SerializeField]
    float timer;
    public UnityEvent response;
    // Use this for initialization
    void Start()
    {
        spawnenemy();
    }
    void spawnenemy()
    {
        StartCoroutine(spawn());
    }
    private IEnumerator spawn()
    {
        for (int i = 0; i <= Spawn_Limit; i++)
        {
            var enemy = Instantiate(Enemy, transform);
            enemy.GetComponent<EnemyBehaviour>().target = player;
            spawncount++;
            yield return new WaitForSeconds(1);
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (spawncount == Spawn_Limit)
        {
            response.Invoke();
        }
    }
}
