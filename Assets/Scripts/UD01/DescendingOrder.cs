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
        //La condición

        if (NumberOne > NumberTwo && NumberTwo > NumberThree)
        {
            Debug.Log("El orden de números introducido es descreciente.");
        }
        else
        {
            Debug.Log("El orden de números introducido no es descreciente.");
        }

    }

}
