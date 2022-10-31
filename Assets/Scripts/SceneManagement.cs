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
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (finalCarrera.final && finalCarrera.gane)
        {
            panelSalir.SetActive(true);
            StartCoroutine(PausarJuego());
        }
        else if (finalCarrera.final && finalCarrera.perdi)
        {
            panelReinicio.SetActive(true);
            StartCoroutine(PausarJuego());
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

    IEnumerator PausarJuego()
    {
        yield return new WaitForSeconds(3f);
        Time.timeScale = 0;
    }
}
