using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnlaceURL : MonoBehaviour
{
    public void EnlaceBoton (string enlace)
    {
        Application.OpenURL(enlace);
    }
}
