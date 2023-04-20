using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
   [SerializeField] AnimController anim;
    public Inventory inventory;

    public GameObject frostMaiden;
    public GameObject GrayArmor;
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
        Debug.Log(moveHorizontal+" "+moveVertical);
        movement.Normalize();
        if (movement != Vector3.zero)
        {
            transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
        }
       anim.SetAnimation((int)moveHorizontal,(int)moveVertical);
        
    }

    public void ChangeClothes()
    {
        anim = Instantiate(frostMaiden, transform, false).GetComponent<AnimController>();
    }
    
    
    public void OpenInventory()
    {
        if (Input.GetKeyUp(KeyCode.I)) 
        {
            InteractionManager.instance.OpenClosePlayerInventory();
        }
    }
    
  
}
