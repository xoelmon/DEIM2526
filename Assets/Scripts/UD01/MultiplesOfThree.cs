using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        IsMultipleThree();

    }

    private void IsMultipleThree()
    {
        // Con for hacemos el bucle de 0 a 100
        for (int i = 0; i <= 100; i++)
        {
            // Comprobamos que esa multiplo de 3
            if (i % 3 == 0)
            {
                Debug.Log("Los múltiplos de 3 de 0 a 100 son: " +  i);
            }
        }

        

    }
  
}
