using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabadora : MonoBehaviour
{
    public List<PuntoMapa> puntos= new List<PuntoMapa>();
    public float periodo= 0.5f;
    public bool grabando = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (!grabando)
            {
                grabando = true;
                StartCoroutine(Grabar());
            }
            else
            {
                grabando = false;
            }
        }

        IEnumerator Grabar()
        {
            while (grabando)
            {
                PuntoMapa pm = new PuntoMapa();
                pm.posicion = transform.position;
                pm.rotacion = transform.rotation;
                puntos.Add(pm);
                yield return new WaitForSeconds(periodo);
            }
        }
    }
}

[System.Serializable]

public class PuntoMapa
{
    public Vector3 posicion;
    public Quaternion rotacion;
}

[CreateAssetMenu(fileName ="IA Carro", menuName ="2DCilantro/IA Carro")]
public class IACarro: ScriptableObject
{
    public List<PuntoMapa> puntos = new List<PuntoMapa>();
}
