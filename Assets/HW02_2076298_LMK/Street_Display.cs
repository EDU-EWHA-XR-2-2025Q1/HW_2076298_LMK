using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Street_Display : MonoBehaviour
{
    public GameObject VideoObject;
    private VideoPlayer videoPlayer;
    
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = VideoObject.GetComponent<VideoPlayer>();

        if (videoPlayer != null)
        {
            videoPlayer.playOnAwake = true; 
        }

        VideoObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N)) 
        {
            if (videoPlayer.isPlaying)
            {
                videoPlayer.Pause(); 
            }
            else
            {
                videoPlayer.Play();
            }
        }  
    }
}
