using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform lookTarget;
    public Transform neckBone;
    float maxNeckRotation = 45.0f;


    private void LateUpdate()
    {
        if (lookTarget != null)
        {

            Vector3 relativePos = lookTarget.position - neckBone.transform.position;
            Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);

            float angle = Vector3.Angle(relativePos, transform.forward);
            if (angle > -maxNeckRotation && angle < maxNeckRotation)
            {
                neckBone.transform.rotation = rotation;
                neckBone.transform.Rotate(0, 0, -90);
            }
        }
    }
}
        