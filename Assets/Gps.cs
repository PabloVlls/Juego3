using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gps : MonoBehaviour
{
    public Text texto;
    public Ubicador personaje;
    IEnumerator Start()
    {

        // Starts the location service.
        Input.location.Start();
        InvokeRepeating("ActualizarPos", 10, 5);
        // Waits until the location service initializes
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }

        // If the service didn't initialize in 20 seconds this cancels location service use.
        if (maxWait < 1)
        {
            print("Timed out");
            yield break;
        }

        // If the connection failed this cancels location service use.
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            print("Unable to determine device location");
            yield break;
        }
        else
        {
            // If the connection succeeded, this retrieves the device's current location and displays it in the Console window.
            while (true)
            {
                texto.text = Input.location.lastData.longitude + "\n" + Input.location.lastData.latitude;
                personaje.posicion.x = Input.location.lastData.latitude;
                personaje.posicion.z = Input.location.lastData.longitude;

                yield return new WaitForSeconds(3f);
            }
            
        }
    }

    public void ActualizarPos()
    {
        personaje.ActualizarPosicion();
    }
}
