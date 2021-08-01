using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTo : MonoBehaviour
{
    public GameObject turnTarget;
    public bool activated;

    public void Activate()
    {
        activated = true;
    }
    

   

    private void LateUpdate()
    {


        if (activated)
        {
            Vector3 relativePos = new Vector3(turnTarget.transform.position.x - transform.position.x, 0.0f, turnTarget.transform.position.z - transform.position.z); //Only rotate around y-Axis
            Quaternion newRotation = Quaternion.LookRotation(relativePos, Vector3.up);
            transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.time * 0.003f);
        }

    }
}
