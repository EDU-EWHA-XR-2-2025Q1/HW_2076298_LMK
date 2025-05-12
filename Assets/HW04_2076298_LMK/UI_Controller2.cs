using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Controller2 : MonoBehaviour
{
    public GameObject text;
    
    public void OnTargetFound()
    {
        if (text != null) text.SetActive(false);
    }
}
