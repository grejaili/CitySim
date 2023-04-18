using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
   
    public string name;
   [SerializeField] protected bool _canInteract;

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
 
     protected virtual void OnTriggerEnter2D(Collider2D other) 
      {
        if (other.CompareTag("Player"))
        {
            _canInteract = true;

            
        }
    }

    protected virtual void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
         
            _canInteract = false;
            
        }
    }
    
    


}
