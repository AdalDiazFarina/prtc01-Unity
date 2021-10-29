using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderA : MonoBehaviour
{
    // Referencia: https://academiaandroid.com/colliders-deteccion-colisiones-juego-unity-3d/
    // https://docs.unity3d.com/ScriptReference/Transform-localScale.html
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "character") {
            gameObject.transform.localScale = new Vector3(2, 2, 2);
        }
    }
}
