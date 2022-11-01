using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollCom : MonoBehaviour
{
    public bool enable = false;
    public UnityEngine.UI.Image popupImg;
    public UnityEngine.UI.Image popupBut;
    public UnityEngine.UI.Button popupBut2;
    public UnityEngine.UI.Image popupImg2;
    public GameObject activar;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (enable)
        {
            popupImg.enabled = true;
            popupImg2.enabled = true;
            popupBut.enabled = true;
            popupBut2.enabled = true;
        }
        else
        {
            popupImg.enabled = false;
            popupImg2.enabled = false;
            popupBut.enabled = false;
            popupBut2.enabled = false;
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enable = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enable = false;
        }
    }
}