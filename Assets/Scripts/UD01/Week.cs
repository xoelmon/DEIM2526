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

    // M�todo
    private void DayWeek()
    {
        switch (NumberDay)
        {
            case 1: 
                Debug.Log("Ese n�mero corresponde al Lunes.");
                break;
         
            case 2:
                Debug.Log("Ese n�mero corresponde al Martes.");
                break;

            case 3:
                Debug.Log("Ese n�mero corresponde al Mi�rcoles.");
                break;

            case 4:
                Debug.Log("Ese n�mero corresponde al Jueves.");
                break;

            case 5:
                Debug.Log("Ese n�mero corresponde al Viernes.");
                break;

            case 6:
                Debug.Log("Ese n�mero corresponde al S�bado.");
                break;

            case 7:
                Debug.Log("Ese n�mero corresponde al Domingo.");
                break;

            default:
                Debug.Log("N�mero de semana incorrecto.");
                break;

        }

    }

}
