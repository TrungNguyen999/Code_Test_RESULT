using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnSplatter : MonoBehaviour
{
    [SerializeField] private GameObject spawnPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnSplatter", 3, 0.5f);
    }

    void SpawnSplatter()
    {
        Instantiate(spawnPrefab, transform.position, transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
