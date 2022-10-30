using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrroPrueba : MonoBehaviour
{
    public bool derEnable = false; 
    public UnityEngine.UI.Image popupDerImg;
    public UnityEngine.UI.Image popupDerBut;

    // Start is called before the first frame update
    void Start()
    {
        popupDerImg.enabled = !popupDerImg.enabled;
        popupDerBut.enabled = !popupDerBut.enabled;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Ing"))
        {
            print("Ing coll");
        }
        if (other.CompareTag("Com"))
        {
            print("Com coll");
        }
        if (other.CompareTag("Der"))
        {
            derEnable = true;
            popupDerImg.enabled = derEnable = true;
            popupDerBut.enabled = derEnable = true;
            print("Der coll");
        }
    }
}
