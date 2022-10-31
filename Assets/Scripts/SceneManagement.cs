using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public GameObject panelReinicio;
    public GameObject panelSalir;
    public FinalCarrera finalCarrera;
    
    void Start()
    {
        finalCarrera = FindObjectOfType<FinalCarrera>();
        panelReinicio.SetActive(false);
        panelSalir.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (finalCarrera.final && finalCarrera.gane)
        {
            panelSalir.SetActive(true);
        }
        else if (finalCarrera.final && finalCarrera.perdi)
        {
            panelReinicio.SetActive(true);
        }

    }

    public void ReiniciarNivel()
    {
        SceneManager.LoadScene("Carrera");
    }

    public void SalirNivel()
    {
        SceneManager.LoadScene("Carrera");
    }
}
