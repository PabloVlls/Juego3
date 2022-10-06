using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Ubicador))]
public class Wismichupapollas : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("Actualizar Posición"))
	    {
            Ubicador u = (Ubicador)target;
            u.ActualizarPosicion();
	    }
    }
}
