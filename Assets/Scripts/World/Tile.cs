using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class Tile : Node
{
    public int x;
    public int y;

    public WorldGrid worldGrid;

    public GameObject gameObject;
    public Tile(WorldGrid world, int _x, int _y) : base()
    {
        worldGrid = world;

        x = _x;
        y = _y;
    }
    public void SetNeighbours()
    {
        int length = worldGrid.mapSize;

        for (int _x = -1; _x <= 1; _x++)
        {
            for (int _y = -1; _y <= 1; _y++)
            {
                if (_x == 0 && _y == 0)
                {
                    continue;
                }

                int checkX = x + _x;
                int checkY = y + _y;

                if (checkX >= 0 && checkX < length && checkY >= 0 && checkY < length)
                {
                    if (worldGrid.GetTile(checkX, checkY) != null)
                    {
                        neighbours.Add(worldGrid.GetTile(checkX, checkY), GetDirection(_x, _y));
                        neighbourDirections.Add(neighbours[worldGrid.GetTile(checkX, checkY)], worldGrid.GetTile(checkX, checkY));
                    }
                }
            }
        }
    }
    public Direction GetDirection(int x, int y)
    {
        if (x == -1)
        {
            switch (y)
            {
                case -1:
                    return Direction.SW;

                case 0:
                    return Direction.W;

                case 1:
                    return Direction.NW;
            }
        }
        else if (x == 0)
        {
            switch (y)
            {
                case -1:
                    return Direction.S;

                case 1:
                    return Direction.N;
            }
        }
        else
        {
            switch (y)
            {
                case -1:
                    return Direction.SE;

                case 0:
                    return Direction.E;

                case 1:
                    return Direction.NE;
            }
        }

        return 0;
    }
}
