using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGrid
{
    public int mapSize;
    Vector2Int worldCentre;

    Tile[,] tiles;

    public WorldGrid()
    {
        mapSize = GameManager.instance.mapSize;

        worldCentre = new Vector2Int(Mathf.FloorToInt(mapSize / 2), Mathf.FloorToInt(mapSize / 2));

        tiles = new Tile[mapSize, mapSize];

        for (int x = 0; x < mapSize; x++)
        {
            for (int y = 0; y < mapSize; y++)
            {
                tiles[x, y] = new Tile(this, x, y);
            }
        }
    }
    public Tile GetTile(float _x, float _y)
    {
        int x = Mathf.FloorToInt(_x);
        int y = Mathf.FloorToInt(_y);

        if (x > mapSize - 1 || x < 0 || y > mapSize - 1 || y < 0)
        {
            return null;
        }

        return tiles[x, y];
    }
}
