using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingCreator : MonoBehaviour
{
    [SerializeField] private FloorAreaCreator floorAreaCreator;
    [SerializeField] private ModellCollections modellCollection;
    [SerializeField] private Transform BuildingPartsContainer;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            CreateBuildings(floorAreaCreator.CreateFloorArea(64, 64, 2, 64, 16, true));
        }
    }

    private void DestroyAllBuildings()
    {
        while(BuildingPartsContainer.childCount > 0)
        {
            Destroy(BuildingPartsContainer.GetChild(0));
        }
    }

    public void CreateBuildings(int[,] area)
    {
        DestroyAllBuildings();
        for (int x = 0; x < area.GetLength(0); x++)
        {
            for (int y = 0; y < area.GetLength(1); y++)
            {
                if(area[x,y] > 0)
                {
                    if(x == 0)
                    {
                        GameObject go = Instantiate(modellCollection.GetRandomWall_X(), BuildingPartsContainer);
                        go.transform.position = new Vector3(x, 0, y);
                    }
                    else if (area[x - 1, y] == 0)
                    {
                        GameObject go = Instantiate(modellCollection.GetRandomWall_X(), BuildingPartsContainer);
                        go.transform.position = new Vector3(x, 0, y);
                    }
                    else
                    {
                        GameObject go = Instantiate(modellCollection.GetRandomCieling_X(), BuildingPartsContainer);
                        go.transform.position = new Vector3(x, 0, y);
                    }

                    if(x == area.GetLength(0))
                    {
                        GameObject go = Instantiate(modellCollection.GetRandomWallX(), BuildingPartsContainer);
                        go.transform.position = new Vector3(x, 0, y);
                    }
                    else if(area[x + 1, y] == 0)
                    {
                        GameObject go = Instantiate(modellCollection.GetRandomWallX(), BuildingPartsContainer);
                        go.transform.position = new Vector3(x, 0, y);
                    }
                    else
                    {
                        GameObject go = Instantiate(modellCollection.GetRandomCielingX(), BuildingPartsContainer);
                        go.transform.position = new Vector3(x, 0, y);
                    }

                    if (y == 0)
                    {
                        GameObject go = Instantiate(modellCollection.GetRandomWall_Y(), BuildingPartsContainer);
                        go.transform.position = new Vector3(x, 0, y);
                    }
                    else if (area[x, y - 1] == 0)
                    {
                        GameObject go = Instantiate(modellCollection.GetRandomWall_Y(), BuildingPartsContainer);
                        go.transform.position = new Vector3(x, 0, y);
                    }
                    else
                    {
                        GameObject go = Instantiate(modellCollection.GetRandomCieling_Y(), BuildingPartsContainer);
                        go.transform.position = new Vector3(x, 0, y);
                    }

                    if (y == area.GetLength(0))
                    {
                        GameObject go = Instantiate(modellCollection.GetRandomWallY(), BuildingPartsContainer);
                        go.transform.position = new Vector3(x, 0, y);
                    }
                    else if (area[x, y + 1] == 0)
                    {
                        GameObject go = Instantiate(modellCollection.GetRandomWallY(), BuildingPartsContainer);
                        go.transform.position = new Vector3(x, 0, y);
                    }
                    else
                    {
                        GameObject go = Instantiate(modellCollection.GetRandomCielingY(), BuildingPartsContainer);
                        go.transform.position = new Vector3(x, 0, y);
                    }

                    GameObject floor = Instantiate(modellCollection.GetRandomFloor(), BuildingPartsContainer);
                    floor.transform.position = new Vector3(x, 0, y);
                    GameObject cieling = Instantiate(modellCollection.GetRandomCieling(), BuildingPartsContainer);
                    cieling.transform.position = new Vector3(x, 0, y);
                }
            }
        }
    }
}
