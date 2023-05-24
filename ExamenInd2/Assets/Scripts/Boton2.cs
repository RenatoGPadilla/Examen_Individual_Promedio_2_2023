using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton2 : MonoBehaviour
{
    public int Score2;

    void OnClick()
    {
        PuntajeUp2();
    }

    void PuntajeUp2()
    {
        Score2 = ScoreManager.Puntaje2 + 1;
        Debug.Log = GetComponent(ScoreManager) < Puntaje2 >;
    }

}
