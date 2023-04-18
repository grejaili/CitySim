using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public string name;
    private bool _canInteract;

    protected virtual void Update()
    {
        StartInteraction();
    }
    
    void StartInteraction()
    {
        if(!_canInteract)
            return;
            
        if (Input.GetKeyUp(KeyCode.E))
        {
            Interaction();
        }
   
    }

    protected virtual void Interaction()
    {
        Debug.Log("SetUP Default Interaction");
    }
 
      void OnTriggerEnter2D(Collider2D other) 
      {
        if (other.CompareTag("Player"))
        {
            _canInteract = true;

            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _canInteract = false;
            
        }
    }
    
    


}
