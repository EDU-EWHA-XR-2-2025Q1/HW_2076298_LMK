using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Street_Sound : MonoBehaviour
{
    public GameObject RadioObject;
    private AudioSource radioAudio;

    // Start is called before the first frame update
    void Start()
    {
        radioAudio = RadioObject.GetComponent<AudioSource>();
        
        if (radioAudio != null) 
        {
            radioAudio.mute = false; // turn on
        }
        RadioObject.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O)) {
            radioAudio.mute = !radioAudio.mute;
        }
    }
}
