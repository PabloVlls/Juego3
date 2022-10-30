using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCarrera : MonoBehaviour
{
    public Collider activaMeta;

    private void Start()
    {
        activaMeta = GetComponent<BoxCollider>();
        activaMeta.enabled = !activaMeta.enabled;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Meta");
        }
    }
}
