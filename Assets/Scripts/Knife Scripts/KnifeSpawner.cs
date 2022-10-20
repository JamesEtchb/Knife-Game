using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject knifePrefab;

    [SerializeField]
    private float min_X = -2.5f, max_X = 2.5f;

    private Vector2 knifePos;

    [SerializeField]
    private float minSpawnTime = 1f, maxSpawnTime = 3f;


    void Start()
    {
        InvokeRepeating("SpawnKnife", Random.Range(minSpawnTime, maxSpawnTime), Random.Range(minSpawnTime, maxSpawnTime));
    }

    void SpawnKnife()
    {
        knifePos.y = transform.position.y;
        knifePos.x = Random.Range(min_X, max_X);

        Instantiate(knifePrefab, knifePos, Quaternion.Euler(0, 0, 90));

    }


}
