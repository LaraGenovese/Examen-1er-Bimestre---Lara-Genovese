using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TICapalooza : MonoBehaviour
{
    // Start is called before the first frame update

    public int entradas_campo, entradas_plateas;

    void Start()
    {
        int entradas_vacantes = 20400 + 16200 - entradas_campo - entradas_plateas;
        int recaudacion_campo, recaudacion_plateas, recaudacion_total;

        recaudacion_campo = 1200 * entradas_campo;
        recaudacion_plateas = 2000 * entradas_plateas;
        recaudacion_total = recaudacion_plateas + recaudacion_campo;

        if (entradas_campo >= 0 && entradas_campo < 20400 && entradas_plateas >= 0 && entradas_plateas < 16200)
        {
            Debug.Log("La recaudación por entradas de Campo es de $" + recaudacion_campo);
            Debug.Log("La recaudación por entradas de Plateas es de $" + recaudacion_plateas);
            Debug.Log("La recaudación TOTAL es de $" + recaudacion_total);

            Debug.Log("Quedaron vacantes: " + entradas_vacantes + " entradas");

            if (entradas_campo > 10200 && entradas_plateas > 8100)
            {
                Debug.Log("El festival fue un éxito!");
            }
            else
            {
                Debug.Log("Debemos mejorar la convocatoria");
            }
        }
        else if (entradas_campo == 20400 && entradas_plateas == 16200)
        {
            Debug.Log("La recaudación por entradas de Campo es de $" + recaudacion_campo);
            Debug.Log("La recaudación por entradas de Plateas es de $" + recaudacion_plateas);
            Debug.Log("La recaudación TOTAL es de $" + recaudacion_total);

            Debug.Log("SOLD OUT!");
        }

        else if (entradas_campo > 20400)
        {
            Debug.Log("ERROR. La cantidad de entradas vendidas para el Campo es mayor al límite");
        }
        else if (entradas_plateas > 16200)
        {
            Debug.Log("ERROR. La cantidad de entradas vendidas para las Plateas es mayor al límite");
        }
        else if (entradas_campo < 0)
        {
            Debug.Log("ERROR. La cantidad de entraadas no puede ser negativa");
        }
        else if (entradas_plateas < 0)
        {
            Debug.Log("ERROR. La cantidad de entradas no puede ser negativa");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
