using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraControl : MonoBehaviour
{
    public Transform objetivoVista;
    public Transform objetivoPosicion;
    public float velocidad;
   

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, objetivoPosicion.position, Time.deltaTime * velocidad);
        transform.LookAt(objetivoVista);
    }
}
