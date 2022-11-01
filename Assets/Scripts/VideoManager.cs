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
        StartCoroutine(FinVideo());
    }

    public void Saltar()
    {
        panelVideo.SetActive(false);
        Video.SetActive(false);
    }

    IEnumerator FinVideo()
    {
        yield return new WaitForSeconds(42f);
        panelVideo.SetActive(false);
        Video.SetActive(false);

    }
}
