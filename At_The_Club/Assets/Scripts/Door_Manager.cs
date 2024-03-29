﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Manager : MonoBehaviour
{

    public bool isOpen;
    public bool isLocked;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OpenClose()
    {
        if (!isLocked)
        anim.SetBool("open", !anim.GetBool("open"));		
	}
    
}
