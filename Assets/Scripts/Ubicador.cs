using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ubicador : MonoBehaviour
{
    public Vector3 posicion;
    public Vector3 referencia;
    public float magnitud;
    // Start is called before the first frame update
    public void Start()
    {
        

    }


    [ContextMenu("Actualizar :v")]
    public void ActualizarPosicion()
    {

        transform.position = (posicion - referencia) * magnitud;
        transform.position = new Vector3(-transform.position.x, transform.position.y, transform.position.z);
    }
}
