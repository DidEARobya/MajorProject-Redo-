using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    N,
    NE,
    E,
    SE,
    S,
    SW,
    W,
    NW
}
public class Node
{
    public Node parent;

    public float gCost;
    public float hCost;
    public float fCost
    {
        get { return gCost + hCost; }
    }

    protected Dictionary<Node, Direction> neighbours = new Dictionary<Node, Direction>();
    protected Dictionary<Direction, Node> neighbourDirections = new Dictionary<Direction, Node>();

    public Node North
    {
        get
        {
            if (neighbourDirections.ContainsKey(Direction.N) == false)
            {
                return null;
            }

            return neighbourDirections[Direction.N];
        }
    }
    public Node East
    {
        get
        {
            if (neighbourDirections.ContainsKey(Direction.E) == false)
            {
                return null;
            }

            return neighbourDirections[Direction.E];
        }
    }
    public Node South
    {
        get
        {
            if (neighbourDirections.ContainsKey(Direction.S) == false)
            {
                return null;
            }

            return neighbourDirections[Direction.S];
        }
    }
    public Node West
    {
        get
        {
            if (neighbourDirections.ContainsKey(Direction.W) == false)
            {
                return null;
            }

            return neighbourDirections[Direction.W];
        }
    }
}
