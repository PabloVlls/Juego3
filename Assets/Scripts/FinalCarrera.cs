using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCarrera : MonoBehaviour
{
    public bool puto = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Prota")
        {
            puto = true;
        }
    }
}
