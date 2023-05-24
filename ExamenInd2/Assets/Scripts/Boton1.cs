using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton1 : MonoBehaviour
{
   public int Score1;

    void OnClick()
    {
        PuntajeUp1();
    }

   void PuntajeUp1()
   {
        Score1 = ScoreManager.Puntaje1 + 1;
        Debug.Log = GetComponent(ScoreManager) < Puntaje1 >;
   }
 
}
