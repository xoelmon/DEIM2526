using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    // Variables globales
    public int NumberDay;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DayWeek();
    }

    // Método
    private void DayWeek()
    {
        switch (NumberDay)
        {
            case 1: 
                Debug.Log("Ese número corresponde al Lunes.");
                break;
         
            case 2:
                Debug.Log("Ese número corresponde al Martes.");
                break;

            case 3:
                Debug.Log("Ese número corresponde al Miércoles.");
                break;

            case 4:
                Debug.Log("Ese número corresponde al Jueves.");
                break;

            case 5:
                Debug.Log("Ese número corresponde al Viernes.");
                break;

            case 6:
                Debug.Log("Ese número corresponde al Sábado.");
                break;

            case 7:
                Debug.Log("Ese número corresponde al Domingo.");
                break;

            default:
                Debug.Log("Número de semana incorrecto.");
                break;

        }

    }

}
