using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPoints : MonoBehaviour
{
    public int[] myIntArray = {1, 5, 10, 15};
    public GameObject[] points;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.FindGameObjectsWithTag("Treasure");
        GameObject.FindGameObjectsWithTag("Player");

        if(Player == Treasure) 
        [
            Destroy(Treasure);
            Debug.Log(" "+i+"points gained"+myIntArray)
        ]
        else if(transform.position.z < bottomOfScene)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }
}
