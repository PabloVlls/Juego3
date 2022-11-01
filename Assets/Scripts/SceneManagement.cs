using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public GameObject panelReinicio;
    public GameObject panelSalir;
    public GameObject panelPausa;
    public GameObject panelInicio;
    public FinalCarrera finalCarrera;
    public IACarroEnemigo iA;
    
    void Start()
    {
        finalCarrera = FindObjectOfType<FinalCarrera>();
        iA = FindObjectOfType<IACarroEnemigo>();
        panelReinicio.SetActive(false);
        panelSalir.SetActive(false);
        panelPausa.SetActive(false);
        panelInicio.SetActive(true);
        Time.timeScale = 0;
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

    public void Inicio()
    {
        panelInicio.SetActive(false);
        Time.timeScale = 1;
    }

    public void ReiniciarNivel()
    {
        SceneManager.LoadScene("Carrera");
    }

    public void SalirNivel()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ScenaDerecho()
    {
        SceneManager.LoadScene("Carrera");
    }

    public void Pausar()
    {
        panelPausa.SetActive(true);
        Time.timeScale = 0;
    }

    public void DesPausar()
    {
        panelPausa.SetActive(false);
        Time.timeScale = 1;
    }

    IEnumerator PausarJuego()
    {
        yield return new WaitForSeconds(3f);
        Time.timeScale = 0;
    }

}
