using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerHex : MonoBehaviour
{
    private static float tileSize = 2;
    public GameObject aimObject;
    public GameObject spearPrefab;

    public Vector3 targetPosition;
    Vector3 up;
    Vector3 rightUp;
    Vector3 rightDown;
    Vector3 down;
    Vector3 leftDown;
    Vector3 leftUp;

    // Start is called before the first frame update
    void Start()
    {
        StartTurn();
    }

    // Update is called once per frame
    void Update()
    {
        // Point aimer
        aimObject.transform.LookAt(targetPosition);

        /* ----NEXT MOVE INPUT----*/
        if (Input.GetAxis("Vertical") > 0 && Input.GetAxis("Horizontal") == 0)
        {
            targetPosition = up;
        }

        if (Input.GetAxis("Vertical") > 0 && Input.GetAxis("Horizontal") > 0)
        {
            targetPosition = rightUp;
        }
        if (Input.GetAxis("Vertical") < 0 && Input.GetAxis("Horizontal") > 0)
        {
            targetPosition = rightDown;
        }
        if (Input.GetAxis("Vertical") < 0 && Input.GetAxis("Horizontal") == 0)
        {
            targetPosition = down;
        }
        if (Input.GetAxis("Vertical") < 0 && Input.GetAxis("Horizontal") < 0)
        {
            targetPosition = leftDown;
        }
        if (Input.GetAxis("Vertical") > 0 && Input.GetAxis("Horizontal") < 0)
        {
            targetPosition = leftUp;
        }

        if (Input.GetKeyDown("space"))
        {
            EndTurn();
        }

        if (Input.GetKeyDown("j"))
        {
            SpearThrow();
        }



    }

    void EndTurn()
    {
        NextTurn();
    }

    void NextTurn()
    {
        PlayerMove();
        StartTurn();
    }

    void StartTurn()
    {
        up = new Vector3(transform.position.x, transform.position.y, transform.position.z + tileSize);
        rightUp = new Vector3(transform.position.x + tileSize * 0.5f, transform.position.y, transform.position.z + tileSize * 0.5f);
        rightDown = new Vector3(transform.position.x + tileSize * 0.5f, transform.position.y, transform.position.z - tileSize * 0.5f);
        down = new Vector3(transform.position.x, transform.position.y, transform.position.z - tileSize);
        leftDown = new Vector3(transform.position.x - tileSize * 0.5f, transform.position.y, transform.position.z - tileSize * 0.5f);
        leftUp = new Vector3(transform.position.x - tileSize * 0.5f, transform.position.y, transform.position.z + tileSize * 0.5f);
    }

    void PlayerMove()
    {
        transform.position = targetPosition;
    }
    
    void SpearThrow()
    {
        GameObject thrownSpear = Instantiate(spearPrefab);
        thrownSpear.transform.SetParent(aimObject.transform);
    }
}
