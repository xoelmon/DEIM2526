using UnityEngine;

public class Substraction : MonoBehaviour
{
    //Variables globales
    public int NumberOne;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        GetSubstraction();

    }

  
    private void GetSubstraction()
    {

        int number = 1;

        for (int i = NumberOne; i >= 2; i--)
        {
            //Hacemos el cálculo

            number -= i;

            Debug.Log("El resultado de la resta consecutiva es: " +  number);

        } 

    }

}
