using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IACarroEnemigo3 : MonoBehaviour
{
    public IACarro3 iaCarro3;
    public float periodo;
    public bool compitiendo = false;
    public int posicionLista = 0;
    float t = 0;

    private void Start()
    {
        transform.position = iaCarro3.puntos[0].posicion;
        compitiendo = true;
        posicionLista = 0;
    }
    void Update()
    {

        if (compitiendo && posicionLista < iaCarro3.puntos.Count - 1)
        {
            t += Time.deltaTime;
            transform.position = Vector3.Lerp
            (iaCarro3.puntos[posicionLista].posicion,
            iaCarro3.puntos[posicionLista + 1].posicion,
            t / periodo
            );

            transform.rotation = Quaternion.Lerp
            (iaCarro3.puntos[posicionLista].rotacion,
            iaCarro3.puntos[posicionLista + 1].rotacion,
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
