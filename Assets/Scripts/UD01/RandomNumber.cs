using UnityEngine;

public class RandomNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetNumber();  
    }

    private void GetNumber()
    {

        // Creamos array con string para texto
        string[] randomArray = new string[5];

        randomArray[0] = "Ganar�s la loter�a.";
        randomArray[1] = "Conocer�s a alguien especial.";   
        randomArray[2] = "Recibir�s una oportunidad laboral.";
        randomArray[3] = "Seguir� todo igual.";
        randomArray[4] = "Aprender�s a programar.";

        // Creamos n�mero aleatorio
        int numberRandom = Random.Range(0, 5);

        // Variable para asignar n�mero aleatorio al array de tipo string
        string prediction = randomArray[numberRandom];

        // Imprimimos la predicci�n aasignada al n�mero aleatorio
        Debug.Log("Tu predicci�n es: " + prediction);

    }           

}
