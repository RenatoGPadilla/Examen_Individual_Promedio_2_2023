using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton3 : MonoBehaviour
{
    public int Score3;

    void OnClick()
    {
        PuntajeUp3();
    }

    void PuntajeUp3()
    {
        Score3 = ScoreManager.Puntaje3 + 1;
        Debug.Log = GetComponent(ScoreManager) < Puntaje3 >;
    }

}
