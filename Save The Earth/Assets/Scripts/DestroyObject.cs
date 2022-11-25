using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour

{
    private float lowerBound = -8;
        private SpawnManager spawnManager;
    private object gameManager;

    // Start is called before the first frame update
    void Start()
    {
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }
    

    // Update is called once per frame
    void Update()
    {
       if(transform.position.z < lowerBound)
        {
            Debug.Log("You Lost");
        }
        
        Destroy(gameObject, 4.0f);
    }
}
        