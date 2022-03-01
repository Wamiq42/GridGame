using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    private List<List<GameObject>> gameObjects;
    private GameObject temp;
    private float horizontalSpacing = 2.0f;
    private float verticalSpacing = 2.0f;
    private int counter = 0;

    public GameObject prefabCube;
    public  int rows;
    public int columns;

    
    private void Awake()
    {
        gameObjects = new List<List<GameObject>>();
        GridInstantiate();

    }

    void GridInstantiate()
    {
        for (int i = 0; i < rows; i++)
        {
            gameObjects.Add(new List<GameObject>());
            for (int j = 0; j < columns; j++)
            {
                CellPositionSetUp();
                temp = Instantiate(prefabCube, new Vector3(horizontalSpacing, 0.5f, verticalSpacing), prefabCube.transform.rotation);
                counter++;
                gameObjects[i].Add(temp);

            }
        }
    }
    void CellPositionSetUp()
    {
        if (counter == rows)
        {
            verticalSpacing += 2.0f;
            counter = 0;
            horizontalSpacing = 4.0f;
        }
        else
        {
            horizontalSpacing += 2.0f;
        }
    }

    public List<List<GameObject>> GetGameObjects()
    {
        return gameObjects;
    }
}
