using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditorInternal;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
    Vector3 position;
    Vector3 topLeft = new Vector3(-30, 0, 30);
    public int horizontalSize;
    public int verticalSize;
    public GameObject tile;
    bool complete = false;
    // Start is called before the first frame update
    void Start()
    {
        position = topLeft;
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
        for (int y = 0; y < verticalSize; ++y)
        {
            for (int x = 0; x < horizontalSize; ++x)
            {
                Instantiate(tile, position, Quaternion.identity);
                position = new Vector3(position.x + 1.5f, position.y, position.z);
            }
            position = new Vector3(topLeft.x, position.y, position.z - 1.5f);
        }
        complete = true;

    }
}
