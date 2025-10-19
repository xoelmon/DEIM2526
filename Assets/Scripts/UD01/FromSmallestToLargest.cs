using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{

    // Variables globales
    public int NumberOne;
    public int NumberTwo;
    public int NumberThree;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AscendingNumber();
    }

    //Todas las condiciones/posibilidades
    private void AscendingNumber()
    {
        if (NumberOne < NumberTwo && NumberTwo < NumberThree)
        {
            Debug.Log("El orden ascendente es: " + NumberOne + NumberTwo + NumberThree);
        }
        else if (NumberTwo < NumberOne && NumberOne < NumberThree)
        {
            Debug.Log("El orden ascendente es: " + NumberTwo + NumberOne + NumberThree);
        }
        else if (NumberOne < NumberThree && NumberThree < NumberTwo)
        {
            Debug.Log("El orden ascendente es: " + NumberOne + NumberThree + NumberTwo);
        }
        else if (NumberTwo < NumberThree && NumberThree < NumberTwo)
        {
            Debug.Log("El orden ascendente es: " + NumberTwo + NumberThree + NumberOne);
        }
        else if (NumberThree < NumberOne && NumberOne < NumberTwo)
        {
            Debug.Log("El orden ascendente es: " + NumberThree + NumberOne + NumberTwo);
        }
        else if (NumberThree < NumberTwo && NumberTwo < NumberOne)
        {
            Debug.Log("El orden ascendente es: " + NumberThree + NumberTwo + NumberOne);
        }
        else if (NumberOne == NumberTwo && NumberTwo == NumberThree)
        {
            Debug.Log("Estos números son iguales");
        }
        else if (NumberThree == NumberOne && NumberOne < NumberTwo)
        {
            Debug.Log("Hay dos números iguales y el tercero es mayor");
        }
        else if (NumberThree == NumberOne && NumberOne > NumberTwo)
        {
            Debug.Log("Hay dos números iguales y el menor es: " + NumberTwo);
        }
        else if (NumberOne == NumberTwo && NumberTwo > NumberThree)
        {
            Debug.Log("Hay dos números iguales y el menor es: " + NumberThree);
        }
        else if (NumberOne == NumberTwo && NumberTwo < NumberThree)
        {
            Debug.Log("Hay dos números iguales y el tercero es mayor");
        }
        else if (NumberTwo == NumberThree && NumberTwo < NumberOne)
        {
            Debug.Log("Hay dos números iguales y el tercero es mayor");
        }
        else if (NumberTwo == NumberThree && NumberTwo > NumberOne)
        {
            Debug.Log("Hay dos números iguales y el menor es: " + NumberOne);
        }
    }



    



}
