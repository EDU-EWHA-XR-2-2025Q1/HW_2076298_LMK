using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1_Controller : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        float localZ = transform.InverseTransformPoint(other.transform.position).z;
        int status = (localZ > 0) ? 1 : 2;

        animator.SetInteger("door1_status", status);
        
        animator.speed = 1f;
    }

    private void OnTriggerExit(Collider other)
    {
        animator.speed = 1f;
    }
}
