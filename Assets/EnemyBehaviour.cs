using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    float tileSize = 1.5f;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnemyMove()
    {
        float xDistance = transform.position.x - player.transform.position.x;
        float zDistance = transform.position.z - player.transform.position.z;

        if (xDistance >= tileSize)
        {
            // move some direction.
        }
    }
}
