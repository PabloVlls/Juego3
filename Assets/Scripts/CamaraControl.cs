using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraControl : MonoBehaviour
{
    public Transform objetivoVista;
    public Transform objetivoPosicion;
    public float velocidad;
   
    private void Start()
    {
        objetivoPosicion.LookAt(objetivoVista);
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, objetivoPosicion.position, Time.deltaTime * velocidad);
        transform.rotation= Quaternion.Lerp(transform.rotation, objetivoPosicion.rotation, Time.deltaTime*velocidad);
    }
}
