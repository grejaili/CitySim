using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject baseTile;
    [SerializeField] Vector2 MapSize;

    public void Create()
    {
      
        
        for (int i = 0; i < MapSize.x; i++)
        {
            for (int j = 0; j < MapSize.y; j++)
            {
                GameObject aux = Instantiate(baseTile,this.transform);
                aux.transform.localPosition = new Vector3(i, j,1);
            }
        }
    }

    public Vector2 GetMapSize()
    {
        return MapSize;
    }

    public Vector2 GetCenterOfTheMap()
    {
        return MapSize / 2;
    }
    
    
}
