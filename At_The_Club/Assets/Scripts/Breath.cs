using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breath : MonoBehaviour
{
    public SkinnedMeshRenderer skinnedMeshRenderer;
    private float rate;
    private float i;

    
    void FixedUpdate()
    {
        i = Time.fixedTime%360;
        rate = (Mathf.Sin(i) + 1)*50; 
        skinnedMeshRenderer.SetBlendShapeWeight(0, rate);
    }
}
