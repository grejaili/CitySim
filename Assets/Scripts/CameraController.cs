using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public float CameraOFFSET;
  
    // Update is called once per frame
    void Update()
    {
        // tween later on 
        this.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, CameraOFFSET);
    }
}
