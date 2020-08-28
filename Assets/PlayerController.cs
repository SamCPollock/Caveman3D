using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int targettedDirection;
    private static float tileSize = 2;
    public GameObject aimObject;

    public Vector3 targettedPosition;
    Vector3 north;
    Vector3 northEast;
    Vector3 east;
    Vector3 southEast;
    Vector3 south;
    Vector3 southWest;
    Vector3 west;
    Vector3 northWest;



    /*
      NUMPAD MOVEMENT:
        789
        456
        123
    */

    // Start is called before the first frame update
    void Start()
    {

        StartTurn();
    }

    // Update is called once per frame
    void Update()
    {
        // Set targetted position


        // Point Aimer
        aimObject.transform.LookAt(targettedPosition);


        /* ---NEXTMOVE INPUT--- */
        // North
        if (Input.GetAxis("Vertical") > 0 && Input.GetAxis("Horizontal") == 0)
        {
            targettedDirection = 8;
            targettedPosition = north;
        }
        // North East
        if (Input.GetAxis("Vertical") > 0 && Input.GetAxis("Horizontal") > 0)
        {
            targettedDirection = 9;
            targettedPosition = northEast;

        }
        // East
        if (Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") > 0)
        {
            targettedDirection = 6;
            targettedPosition = east;
        }
        // South East
        if (Input.GetAxis("Vertical") < 0 && Input.GetAxis("Horizontal") > 0)
        {
            targettedDirection = 3;
            targettedPosition = southEast;
        }
        // South
        if (Input.GetAxis("Vertical") < 0 && Input.GetAxis("Horizontal") == 0)
        {
            targettedDirection = 2;
            targettedPosition = south;
        }
        // South West
        if (Input.GetAxis("Vertical") < 0 && Input.GetAxis("Horizontal") < 0)
        {
            targettedDirection = 1;
            targettedPosition = southWest;
        }
        // West
        if (Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") < 0)
        {
            targettedDirection = 4;
            targettedPosition = west;
        }
        // North West
        if (Input.GetAxis("Vertical") > 0 && Input.GetAxis("Horizontal") < 0)
        {
            targettedDirection = 7;
            targettedPosition = northWest;
        }

        if (Input.GetKeyUp("space"))
        {
            EndTurn();
        }





        /* Direct movement.
        if (Input.GetAxis("Horizontal") > 0)
        {
            // Move Right
            transform.Translate(Vector3.right);
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            // Move Left
            transform.Translate(Vector3.left);
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            // Move Up
            transform.Translate(Vector3.forward);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            // Move Down
            transform.Translate(Vector3.back);
        }
        */

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
        north = new Vector3(transform.position.x, transform.position.y, transform.position.z + tileSize);
        northEast = new Vector3(transform.position.x + tileSize * 0.5f, transform.position.y, transform.position.z + tileSize * 0.5f);
        east = new Vector3(transform.position.x + tileSize, transform.position.y, transform.position.z);
        southEast = new Vector3(transform.position.x + tileSize * 0.5f, transform.position.y, transform.position.z - tileSize * 0.5f);
        south = new Vector3(transform.position.x, transform.position.y, transform.position.z - tileSize);
        southWest = new Vector3(transform.position.x - tileSize * 0.5f, transform.position.y, transform.position.z- tileSize * 0.5f);
        west = new Vector3(transform.position.x - tileSize, transform.position.y, transform.position.z);
        northWest = new Vector3(transform.position.x - tileSize * 0.5f, transform.position.y, transform.position.z + tileSize * 0.5f);
    }

    void PlayerMove()
    {
        // Turn Movement

        transform.position = targettedPosition;
        //if (targettedDirection == 8)
        //{
        //    transform.position = north;
        //}
        //if (targettedDirection == 9)
        //{
        //    transform.position = northEast;
        //}
        //if (targettedDirection == 6)
        //{
        //    transform.position = east;
        //}
        //if (targettedDirection == 3)
        //{
        //    transform.position = southEast;
        //}
        //if (targettedDirection == 2)
        //{
        //    transform.position = south;
        //}
        //if (targettedDirection == 1)
        //{
        //    transform.position = southWest;
        //}
        //if (targettedDirection == 4)
        //{
        //    transform.position = west;
        //}
        //if (targettedDirection == 7)
        //{
        //    transform.position = northWest;
        //}
    }
}
