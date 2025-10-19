using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        IsMultipleThreeTwo();

    }

    private void IsMultipleThreeTwo()
    {
        // Con for hacemos el bucle de 0 a 100
        for (int i = 0; i <= 100; i++)
        {
            // Comprobamos que esa multiplo de 3
            if (i % 3 == 0 && i % 2 == 0)
            {
                Debug.Log("Los múltiplos de 3 y de 2 de 0 a 100 son: " + i);
            }
        }

        // Con while 
        // int i = 0;
        // while (i <= 100)
        // {
        //     if (i % 3 == 0)
        //     {
        //     Debug.Log(i);
        //     }
        // i++;
        // }
        

        // También podriamos poner los múltiplos de 6 que es el mínimo común multiplo de 3 y 2.
        
    }

}
