using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    public int mapSize;

    //[SerializeField]
    //public WorldController worldController;

    [SerializeField]
    public SpriteAtlas terrainAtlas;
    [SerializeField]
    public SpriteAtlas floorAtlas;
    [SerializeField]
    public SpriteAtlas itemAtlas;
    [SerializeField]
    public SpriteAtlas objectAtlas;

    WorldGrid worldGrid;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        //worldController.Init(tileSpriteController);
        //worldGrid = worldController.worldGrid;
    }
}
