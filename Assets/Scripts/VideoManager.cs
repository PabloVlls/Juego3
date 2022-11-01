using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoManager : MonoBehaviour
{
    public GameObject panelVideo;
    public GameObject Video;
    // Start is called before the first frame update
    void Start()
    {
        panelVideo.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Saltar()
    {
        panelVideo.SetActive(false);
        Video.SetActive(false);
    }
}
