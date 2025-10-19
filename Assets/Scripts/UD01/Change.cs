using UnityEngine;

public class Change : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EnterosArray();
    }

    private void EnterosArray()
    {

        // Creamos array y definimos valores
        int[] numbersArray = new int[5] { 1, 1, 1, 1, 1 };

        // Imprimimos número de elementos
        Debug.Log("El número de elementos del array son: " + numbersArray.Length);

        // Cambiamos valores 
        numbersArray[0] = 42;
        numbersArray[4] = 42;

        // Imprimimos valores del array
        for (int i = 0; i < numbersArray.Length; i++)
        {
            Debug.Log(numbersArray[i]);

        }
    }
}
