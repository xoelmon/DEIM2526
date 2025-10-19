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

        randomArray[0] = "Ganarás la lotería.";
        randomArray[1] = "Conocerás a alguien especial.";   
        randomArray[2] = "Recibirás una oportunidad laboral.";
        randomArray[3] = "Seguirá todo igual.";
        randomArray[4] = "Aprenderás a programar.";

        // Creamos número aleatorio
        int numberRandom = Random.Range(0, 5);

        // Variable para asignar número aleatorio al array de tipo string
        string prediction = randomArray[numberRandom];

        // Imprimimos la predicción aasignada al número aleatorio
        Debug.Log("Tu predicción es: " + prediction);

    }           

}
