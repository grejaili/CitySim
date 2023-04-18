using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    [SerializeField] Animator anim;
    public Inventory inventory;

    
    
    private void Update()
    {
        Move();
        OpenInventory();
    }

    private void Move()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
        movement.Normalize();
        if (movement != Vector3.zero)
        {
            transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
        }
        anim.SetFloat("Speed", movement.magnitude);
    }


    public void OpenInventory()
    {
        if (Input.GetKeyUp(KeyCode.I)) 
        {
            InteractionManager.instance.OpenClosePlayerInventory();
        }
    }
    
  
}
