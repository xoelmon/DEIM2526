using UnityEngine;

public class Even : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        IsEven();

    }

    private void IsEven()
    {

        for (int i = 0; i <= 100; i++)
        {
            // Solo los pares
            if (i % 2 == 0)
            {
                Debug.Log("Los números pares de 0 a 100 son: " + i);
            }

        }

    }

}
