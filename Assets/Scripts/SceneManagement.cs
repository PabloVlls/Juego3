using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public GameObject panelReinicio;
    public FinalCarrera finalCarrera;
    
    void Start()
    {
        finalCarrera = FindObjectOfType<FinalCarrera>();
        panelReinicio.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (finalCarrera.final)
        {
            panelReinicio.SetActive(true);
            
        }

    }

    public void ReiniciarNivel()
    {
        SceneManager.LoadScene("Carrera");
    }
}
