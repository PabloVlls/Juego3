using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IACarroEnemigo : MonoBehaviour
{
    public IACarro iaCarro;
    public float periodo;
    public bool compitiendo = false;
    public int posicionLista = 0;
    float t = 0;

    private void Start()
    {
        transform.position = iaCarro.puntos[0].posicion;
        compitiendo = true;
        posicionLista = 0;
    }
    void Update()
    {

        if (compitiendo && posicionLista < iaCarro.puntos.Count-1)
        {
            t += Time.deltaTime;
            transform.position = Vector3.Lerp
            (iaCarro.puntos[posicionLista].posicion,
            iaCarro.puntos[posicionLista + 1].posicion,
            t/periodo
            );

            transform.rotation = Quaternion.Lerp
            (iaCarro.puntos[posicionLista].rotacion,
            iaCarro.puntos[posicionLista + 1].rotacion,
            t/periodo
            );
            
            if (t >= periodo)
            {
                posicionLista++;
                t = 0;
            }
        }
    }
}
