using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditorInternal;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
    public float tileSize;
    Vector3 position;
    Vector3 topLeft = new Vector3(-5, 0, 5);
    public int horizontalSize;
    public int verticalSize;
    public int totalTiles;
    public GameObject tile;
    bool complete = false;
    // Start is called before the first frame update
    void Start()
    {
        position = topLeft;
        totalTiles = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!complete)
        {
            GenerateTiles();
        }
    }

    void GenerateTiles()
    {
        // TODO: Make them generate top to bottom, then go one to the right and shift slightly, then top to bottom again.
        for (int x = 0; x < horizontalSize; x++)
        {
            for (int y = 0; y < verticalSize; y++)
            {
                Instantiate(tile, position, Quaternion.identity);
                position = new Vector3(position.x, position.y, position.z - tileSize);
                totalTiles++;
            }
            position = new Vector3(position.x + (tileSize * 0.75f), topLeft.y, topLeft.z + ((tileSize * 0.5f) * x + 1));
        }
        complete = true;

        //for (int y = 0; y < verticalSize; ++y)
        //{
        //    for (int x = 0; x < horizontalSize; ++x)
        //    {
        //        Instantiate(tile, position, Quaternion.identity);
        //        position = new Vector3(position.x + 1.5f, position.y, position.z);
        //    }
        //    position = new Vector3(topLeft.x, position.y, position.z - 1.5f);
        //}
        //complete = true;

    }
}
