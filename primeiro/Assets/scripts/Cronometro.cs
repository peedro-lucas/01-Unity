using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class Cronometro : MonoBehaviour
{
    public int LimiteDosSegundos;
    public float Segundos;
    public int Minutos;

    public TextMeshProUGUI cronometro_text;


    
    void FixedUpdate()
    {
        cronometro_text.text = "Tempo " + (int)Segundos;
        Segundos += Time.deltaTime;
        if(Segundos >= LimiteDosSegundos)
        {
            Minutos++;
            Segundos = 0 + 1;
        }

    }
}

