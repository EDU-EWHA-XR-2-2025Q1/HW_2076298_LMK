using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2_Timeline_Controller : MonoBehaviour
{
    public void OnFrameEnter_Stop()
    {
        GetComponent<Animator>().speed = 0f;
    }
}
