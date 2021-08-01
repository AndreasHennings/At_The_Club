using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour

{
    Animator animator;
    public float rate;

    void Start()
    {
        animator = GetComponent<Animator>();
        rate = 0.5f;
    }

    
    void Update()
    {
        if (Random.Range(0.0f, 1.0f) > rate) { animator.SetTrigger("Blink"); }
    }
}
