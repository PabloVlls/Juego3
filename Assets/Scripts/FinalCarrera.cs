using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FinalCarrera : MonoBehaviour
{
    public Collider activaMeta;
    public bool llegada = false;
    public bool final = false;

    private void Start()
    {
        activaMeta = GetComponent<BoxCollider>();
        activaMeta.enabled = !activaMeta.enabled;
        
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
        }
        else if (other.gameObject.CompareTag("Enemy") && llegada == true)
        {
            Debug.Log("Meta3");
            final = true;
        }

    }

    void Activar()
    {
        if(llegada)
        {
            activaMeta.enabled = !activaMeta.enabled;
        }
    }

   
}
