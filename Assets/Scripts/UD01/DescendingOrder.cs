using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    // Variables globales
    public int NumberOne;
    public int NumberTwo;
    public int NumberThree;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        IsDescending();

    }

    private void IsDescending()
    {
        //La condici�n

        if (NumberOne > NumberTwo && NumberTwo > NumberThree)
        {
            Debug.Log("El orden de n�meros introducido es descreciente.");
        }
        else
        {
            Debug.Log("El orden de n�meros introducido no es descreciente.");
        }

    }

}
