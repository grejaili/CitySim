using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    public Animator animator;


    // Update is called once per frame
   public void SetAnimation(int  horizontal,int  vertical)
    {
        animator.SetInteger("SpeedHorizontal", horizontal);
        animator.SetInteger("SpeedVertical", vertical);
    }
}
