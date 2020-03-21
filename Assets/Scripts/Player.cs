﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platform2DUtils.GameplaySystem;


public class Player : Character2D
{
    void Update()
    {
       GameplaySystem.MovementTopdown(rb2D.transform,moveSpeed);
    }

    void FixedUpdate()
    {
        if(GameplaySystem.JumpBtn && !jump)
        {   
            GameplaySystem.JumpTopdown(transform);
            jump = true;
            invencible = true;
            StartCoroutine(JumpTime());
        }

        
        IEnumerator JumpTime()
        {
            yield return new WaitForSeconds(0.5f);
            transform.localScale =new Vector3(75.0f,75.0f,1.0f);
            jump = false;
            invencible = false;
        }
    }
}
