using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1_Controller : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator.speed = 0f;
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.speed = 1f;
    }

    private void OnTriggerExit(Collider other)
    {
        animator.speed = 1f;
    }
}
