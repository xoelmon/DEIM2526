using UnityEngine;

public class FromLargestToSmaller : MonoBehaviour
{
    // Variables Globales
    public int NumberOne;
    public int NumberTwo;
    public int NumberThree;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DescendingNumber();
    }

    //Todas las posibilidades
    private void DescendingNumber()
    {
        if (NumberOne >= NumberTwo && NumberTwo >= NumberThree)
        {
            Debug.Log("Los números de mayor a menor son: " + NumberOne + NumberTwo + NumberThree);
        }

        else if (NumberOne >= NumberThree && NumberThree >= NumberTwo)
        {
            Debug.Log("Los números de mayor a menos son: " + NumberOne + NumberThree + NumberTwo);
        }

        else if (NumberTwo >= NumberOne && NumberOne >= NumberThree)
        {
            Debug.Log("Los números de mayor a menos son: " + NumberTwo + NumberOne + NumberThree);
        }

        else if (NumberTwo >= NumberThree && NumberThree >= NumberTwo)
        {
            Debug.Log("Los números de mayor a menor son: " + NumberTwo + NumberThree + NumberOne);
        }

        else if (NumberThree >= NumberOne && NumberOne >= NumberTwo)
        {
            Debug.Log("Los números de mayor a menor son: " + NumberThree + NumberOne + NumberTwo);
        }

        else if (NumberThree >= NumberTwo && NumberTwo >= NumberOne)
        {
            Debug.Log("Los números de mayor a menor son: " + NumberThree + NumberTwo + NumberOne); 
        }
    }
        



}
