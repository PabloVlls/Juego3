using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivaMeta : MonoBehaviour
{
    public FinalCarrera finalCarrera;

    private void Start()
    {
        finalCarrera = FindObjectOfType<FinalCarrera>();
    }
    private void Update()
    {
        
    }

}
