using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle_Controller : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator.speed = 0f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Vehicle")
        {
            animator.speed = 1f;

            transform.SetParent(other.transform);
            transform.position = other.transform.position + Vector3.up * 2f;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Vehicle")
        {
            transform.SetParent(null);

            animator.speed = 0f;
        }
    }
}
