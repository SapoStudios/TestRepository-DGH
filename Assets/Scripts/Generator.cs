using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    // Start is called before the first frame update

    public int width, height;
    GameObject[,] map;
    public GameObject cube;
    void Start()
    {
        GameObject[,] map = new GameObject[width, height];
        for (int i = 0; i< width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                map[i,j] = Instantiate(cube, new Vector2(i, j), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
