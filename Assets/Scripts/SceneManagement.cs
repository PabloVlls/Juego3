using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public GameObject panelReinicio;
    public GameObject panelSalir;
    public FinalCarrera finalCarrera;
    public IACarroEnemigo iA;
    
    void Start()
    {
        finalCarrera = FindObjectOfType<FinalCarrera>();
        iA = FindObjectOfType<IACarroEnemigo>();
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
            /*iA.compitiendo = false;
            iA.posicionLista = 0;*/
        }
        else if (finalCarrera.final && finalCarrera.perdi)
        {
            panelReinicio.SetActive(true);
            StartCoroutine(PausarJuego());
            /*iA.compitiendo = false;
            iA.posicionLista = 0;*/
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
