using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class LevelManager : MonoBehaviour
{
    [SerializeField] MapGenerator mapGenerator;
    [SerializeField] private GameObject player;
    [SerializeField] private Grid _grid;
    public static LevelManager instance;
    
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        mapGenerator.Create();
        player.transform.position = _grid.WorldToCell(mapGenerator.GetCenterOfTheMap());
    }

    public void LoadManager()
    {
        
    }
    
}

