using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrroPrueba : MonoBehaviour
{
    public UnityEngine.UI.Image PopupDerImg;
    public UnityEngine.UI.Image PopupDerBut;
    // Start is called before the first frame update
    void Start()
    {
        PopupDerImg.enabled = !PopupDerImg.enabled;
        PopupDerBut.enabled = !PopupDerBut.enabled;
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
            print("Der coll");
        }
    }
}
