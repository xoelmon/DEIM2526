using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{
    // Variables globales
    public int NumberOne;
    public int NumberTwo;
    public int NumberThree;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        IsIncreasing();

    }

    private void IsIncreasing()
    {
        //La condici�n
        if (NumberOne < NumberTwo && NumberTwo < NumberThree)
        {
            Debug.Log("El orden de n�meros introducido es creciente.");
        }
        else 
        {
            Debug.Log("El orden de n�meros introducido no es creciente.");
        }

    }
}
