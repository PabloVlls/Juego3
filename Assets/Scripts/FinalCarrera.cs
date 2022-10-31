using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FinalCarrera : MonoBehaviour
{
    public Collider activaMeta;
    public bool llegada = false;
    public bool final = false;
    public bool gane = false;
    public bool perdi = false;

    private void Start()
    {
        activaMeta = GetComponent<BoxCollider>();
        activaMeta.enabled = false;
    }

    private void Update()
    {
        Activar();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && llegada == true)
        {
            Debug.Log("Meta2");
            final = true;
            gane = true;
        }
        else if (other.gameObject.CompareTag("Enemy") && llegada == true)
        {
            Debug.Log("Meta3");
            final = true;
            perdi = true;
        }

    }

    void Activar()
    {
        if(llegada)
        {
            activaMeta.enabled = true;
        }
    }

   
}
