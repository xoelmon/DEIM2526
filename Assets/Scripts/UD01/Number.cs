using UnityEngine;

public class Number : MonoBehaviour
{
    //Variables globales
    [SerializeField]
    private int _number;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        GetNumber(_number);

    }

    //Usamos el paso por parámetro
   private void GetNumber(int numberOne)
    {
        //Hacemos el cálculo

        int result = numberOne + 1;

        Debug.Log("El resultado es: " + result);

    }

}
