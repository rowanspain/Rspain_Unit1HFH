using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Prefabs;
    private float xPosRange = 13;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomTreasure", 3.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {   
     
    }

    void SpawnRandomTreasure()
    {
        float randXPos = Random.Range(-xPosRange, xPosRange);
            int animalPrefabIndex = Random.Range(0, Prefabs.Length);
            Vector3 randPos = new Vector3(randXPos, 0, 21);
            Instantiate(Prefabs[animalPrefabIndex], randPos, Prefabs[animalPrefabIndex].transform.rotation);
    }
}
