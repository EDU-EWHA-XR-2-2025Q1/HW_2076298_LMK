using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Controller : MonoBehaviour
{
    public GameObject text;
    public Heart_Container heartContainer;
    
    public void OnTargetFound()
    {
        if (text != null) text.SetActive(false);
        if (heartContainer != null) heartContainer.Clone_Items();
    }
}
