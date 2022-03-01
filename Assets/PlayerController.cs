using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GridManager gridManager;


    private List<List<GameObject>> listGameObjects;
    private Vector3 offset = new Vector3(0, 1f, 0);
    private int currentColumn = 0;
    private int currentRow = 0;
    private int rows;
    private int cols;

    // Start is called before the first frame update
    void Start()
    {
        listGameObjects = gridManager.GetGameObjects();
        rows = gridManager.rows;
        cols = gridManager.columns;
        transform.position = listGameObjects[currentRow][currentColumn].transform.position + new Vector3(0f, 0.5f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (currentColumn >= 0 && currentColumn < cols)
            {

                if (currentColumn != 0)
                {
                    currentColumn--;
                }
                transform.position = listGameObjects[currentRow][currentColumn].transform.position + offset;
            }
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            if (currentColumn >= 0 && currentColumn < cols)
            {
                if (currentColumn < cols - 1)
                {
                    currentColumn++;
                }

                transform.position = listGameObjects[currentRow][currentColumn].transform.position + offset;
            }
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            if (currentRow >= 0 && currentRow < rows)
            {
                if (currentRow != 0)
                {
                    currentRow--;
                }

                transform.position = listGameObjects[currentRow][currentColumn].transform.position + offset;
            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (currentRow >= 0 && currentRow < rows)
            {
                if (currentRow < rows - 1)
                {
                    currentRow++;
                }

                transform.position = listGameObjects[currentRow][currentColumn].transform.position + offset;
            }
        }
    }
}

