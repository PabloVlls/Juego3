using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCarrera : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Prota")
        {
            Debug.Log("SapoPrro");
        }
    }
}
