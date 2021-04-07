using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FloorAreaCreator : MonoBehaviour
{
    
    [SerializeField] SpriteRenderer debugImageRenderer;
    public int[,] CreateFloorArea(int width, int depth, int numberOfSquares, int mainHouseMaxSize, int mainHouseMinSize, bool showOnDebug = false)
    {
        int[,] floorArray = CreateIntArrayAndFill(width, depth, 0);
        //create new squares
        for (int i = 0; i < numberOfSquares; i++)
        {
            //mostTopleft Start of the main building is width or depth - mainHouseMaxSize to prevent overdrawing
            int[] corners = CreateRandomSquare(width, depth, mainHouseMaxSize, mainHouseMinSize);
            Debug.Log("Corners " + i + ":" + corners[0] + "," + corners[1] + "," + corners[2] + "," + corners[3]);
            for (int x = corners[0]; x < corners[0] +  corners[2]; x++)
            {
                for (int y = corners[1]; y < corners[1] + corners[3]; y++)
                {
                    floorArray[x, y] += 1;
                }
            }
        }

        if (showOnDebug)
        {
            ShowDebugArea(floorArray);
        }
        return floorArray;
    }

    private void ShowDebugArea(int[,] floorArea)
    {
        Texture2D paintedArea = new Texture2D(floorArea.GetLength(0), floorArea.GetLength(1));
        for (int x = 0; x < paintedArea.width; x++)
        {
            for (int y = 0; y < paintedArea.height; y++)
            {
                if(floorArea[x,y] == 0)
                {
                    paintedArea.SetPixel(x, y, Color.white);
                }
                else
                {
                    paintedArea.SetPixel(x, y, Color.white * 1/floorArea[x,y]);
                }
            }
        }
        paintedArea.Apply();
        debugImageRenderer.sprite = Sprite.Create(paintedArea, new Rect(0,0,paintedArea.width, paintedArea.height), new Vector2(0,0));
        debugImageRenderer.transform.localScale = new Vector3(paintedArea.width * 2, paintedArea.height * 2, 1);
    }

    private int[] CreateRandomSquare(int width, int height, int maxSize, int minSize = 0, int minStartX = 0, int minStartY = 0)
    {
        int[] squarePoints = new int[4];
        //Width
        squarePoints[2] = Random.Range(minSize, maxSize);
        //Height
        squarePoints[3] = Random.Range(minSize, maxSize);
        //Start x
        squarePoints[0] = Random.Range(minStartX, width - squarePoints[2]);
        //Start y
        squarePoints[1] = Random.Range(minStartY, height - squarePoints[3]);
        

        return squarePoints;
    }
    private int[,] CreateIntArrayAndFill(int x, int y, int fillValue)
    {
        int[,] newFilledArray = new int[x, y];
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                newFilledArray[i, j] = fillValue;
            }
        }
        return newFilledArray;
    }
}
