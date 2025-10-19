using UnityEngine;

public class Score : MonoBehaviour

{
    // Variables globales
    [SerializeField]
    private int _lifePoints;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        Points(_lifePoints);

    }

    private void Points(int number)
    {
        //Reconocemos si llega o supera 45
        if (number >= 45)
        {
            Debug.Log("Se ha llegado a 45.");
        }
        else
        {
            Debug.Log("No se ha llegado a 45.");
        }

    }

}
