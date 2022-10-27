using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IACarroEnemigo : MonoBehaviour
{
    public IACarro iaCarro;
    public float periodo;
    public bool compitiendo = false;
    public float frames=10f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (!compitiendo)
            {
                compitiendo = true;
                StartCoroutine(Grabar());
            }
            else
            {
                compitiendo = false;
            }
        }
    }

    IEnumerator Grabar()
    {
        int posicionLista = 0;
        while (compitiendo)
        {
            PuntoMapa pm = new PuntoMapa();
            for (int i = 0; i < frames; i++)
            {
                transform.position = Vector3.Lerp
                (iaCarro.puntos[posicionLista].posicion, 
                iaCarro.puntos[posicionLista + 1].posicion, 
                (float)i/ (frames)
                );

                transform.rotation = Quaternion.Lerp
                (iaCarro.puntos[posicionLista].rotacion,
                iaCarro.puntos[posicionLista + 1].rotacion,
                (float)i / (frames)
                );
                yield return new WaitForSeconds(periodo/frames);
            }
             posicionLista++;
        }
    }
}
