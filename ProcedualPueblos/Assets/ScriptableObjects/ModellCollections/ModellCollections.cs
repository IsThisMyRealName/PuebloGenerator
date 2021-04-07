using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewModellCollection", menuName = "ScriptableObjects/NewModellCollection", order = 1)]
public class ModellCollections : ScriptableObject
{
    public GameObject[] Cielings;
    public GameObject[] CielingsX;
    public GameObject[] CielingsY;
    public GameObject[] Cielings_X;
    public GameObject[] Cielings_Y;
    public GameObject[] CollumnsXY;
    public GameObject[] CollumnsX_Y;
    public GameObject[] Collumns_XY;
    public GameObject[] Collumns_X_Y;
    public GameObject[] Floors;
    public GameObject[] FloorsX;
    public GameObject[] FloorsY;
    public GameObject[] Floors_X;
    public GameObject[] Floors_Y;
    public GameObject[] WallsX;
    public GameObject[] WallsY;
    public GameObject[] Walls_X;
    public GameObject[] Walls_Y;

    public GameObject GetRandomCieling()
    {
        return Cielings[Random.Range(0, Cielings.Length)];
    }

    public GameObject GetRandomCielingX()
    {
        return CielingsX[Random.Range(0, CielingsX.Length)];
    }

    public GameObject GetRandomCielingY()
    {
        return CielingsY[Random.Range(0, CielingsY.Length)];
    }

    public GameObject GetRandomCieling_X()
    {
        return Cielings_X[Random.Range(0, Cielings_X.Length)];
    }

    public GameObject GetRandomCieling_Y()
    {
        return Cielings_Y[Random.Range(0, Cielings_Y.Length)];
    }

    public GameObject GetRandomCollumnXY()
    {
        return CollumnsXY[Random.Range(0, CollumnsXY.Length)];
    }

    public GameObject GetRandomCollumnX_Y()
    {
        return CollumnsX_Y[Random.Range(0, CollumnsX_Y.Length)];
    }

    public GameObject GetRandomCollumn_XY()
    {
        return Collumns_XY[Random.Range(0, Collumns_XY.Length)];
    }

    public GameObject GetRandomCollumn_X_Y()
    {
        return Collumns_X_Y[Random.Range(0, Collumns_X_Y.Length)];
    }

    public GameObject GetRandomFloor()
    {
        return Floors[Random.Range(0, Floors.Length)];
    }

    public GameObject GetRandomFloorX()
    {
        return FloorsX[Random.Range(0, FloorsX.Length)];
    }

    public GameObject GetRandomFloorY()
    {
        return FloorsY[Random.Range(0, FloorsY.Length)];
    }

    public GameObject GetRandomFloor_X()
    {
        return Floors_X[Random.Range(0, Floors_X.Length)];
    }

    public GameObject GetRandomFloor_Y()
    {
        return Floors_Y[Random.Range(0, Floors_Y.Length)];
    }

    public GameObject GetRandomWallX()
    {
        return WallsX[Random.Range(0, WallsX.Length)];
    }

    public GameObject GetRandomWallY()
    {
        return WallsY[Random.Range(0, WallsY.Length)];
    }

    public GameObject GetRandomWall_X()
    {
        return Walls_X[Random.Range(0, Walls_X.Length)];
    }

    public GameObject GetRandomWall_Y()
    {
        return Walls_Y[Random.Range(0, Walls_Y.Length)];
    }
}
