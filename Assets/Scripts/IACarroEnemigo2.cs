using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IACarroEnemigo2 : MonoBehaviour
{
    public IACarro2 iaCarro2;
    public float periodo;
    public bool compitiendo = false;
    public int posicionLista = 0;
    float t = 0;

    private void Start()
    {
        transform.position = iaCarro2.puntos[0].posicion;
        compitiendo = true;
        posicionLista = 0;
    }
    void Update()
    {

        if (compitiendo && posicionLista < iaCarro2.puntos.Count - 1)
        {
            t += Time.deltaTime;
            transform.position = Vector3.Lerp
            (iaCarro2.puntos[posicionLista].posicion,
            iaCarro2.puntos[posicionLista + 1].posicion,
            t / periodo
            );

            transform.rotation = Quaternion.Lerp
            (iaCarro2.puntos[posicionLista].rotacion,
            iaCarro2.puntos[posicionLista + 1].rotacion,
            t / periodo
            );

            if (t >= periodo)
            {
                posicionLista++;
                t = 0;
            }
        }
    }
}
