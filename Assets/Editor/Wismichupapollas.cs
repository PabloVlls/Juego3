using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Ubicador))]
public class Wismichupapollas : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("Actualizar Posici�n"))
	    {
            Ubicador u = (Ubicador)target;
            u.ActualizarPosicion();
	    }
    }
}
