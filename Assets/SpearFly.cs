using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearFly : MonoBehaviour
{
    public float speed;
    public float range;
    Vector3 startPoint;
    private Vector3 endPoint;

    // Start is called before the first frame update
    void Start()
    {
        PlayerControllerHex playerController = GetComponentInParent<PlayerControllerHex>();
        //transform.LookAt(playerController.targetPosition); // obsolete, instantiated with rotation of aimObject in playerControllerHex.
        Vector3 startPoint = transform.position;
        //endPoint = new Vector3(transform.position.x, transform.position.y, transform.position.z + range);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);

        if (Vector3.Distance(startPoint, transform.position) > range)
        {
            Destroy(gameObject);
        }
    }
}
