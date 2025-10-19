using UnityEngine;

public class Logic : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetLogic();
    }

    private void GetLogic()
    {

        //Creamos array inicializado en false
        bool[] boolArray = new bool[3] {false, false, false};

        //Marcamos verdadero el primer cajón
        boolArray[0] = true;

        //Imprimimos en consola
        Debug.Log("El valor de la primera casilla es: " + boolArray[0]);
        Debug.Log("El valor de la segunda casilla es: " + boolArray[1]);
        Debug.Log("El valor de la tercera casilla es: " + boolArray[2]);
    }
}
