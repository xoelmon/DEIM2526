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
                Debug.Log("Los m�ltiplos de 3 y de 2 de 0 a 100 son: " + i);
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
        

        // Tambi�n podriamos poner los m�ltiplos de 6 que es el m�nimo com�n multiplo de 3 y 2.
        
    }

}
