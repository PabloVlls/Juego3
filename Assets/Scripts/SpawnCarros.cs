using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCarros : MonoBehaviour
{
    private Vector3 spawnPosition;
    public Transform spawnEnemy;
    public GameObject carroEnemy;

    void Start()
    {
        Quaternion angulo = carroEnemy.transform.rotation;
        spawnPosition = spawnEnemy.position;
        Instantiate(carroEnemy, spawnPosition, angulo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
