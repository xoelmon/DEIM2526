using UnityEngine;

public class Odd : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        IsOdd();

    }

    private void IsOdd()
    {

        for (int i = 0; i <= 100; i++)
        {
            // Solo los impares
            if (i % 2 != 0)
            {
                Debug.Log("Los números impares de 0 a 100 son: " + i);
            }

        }

    }
}
