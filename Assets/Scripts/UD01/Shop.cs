using UnityEngine;

public class Shop : MonoBehaviour
{
    //Variables globales

    [SerializeField]
    private int _unidadesBrecol;
    [SerializeField]
    private int _unidadesPatata;
    [SerializeField]
    private bool _addProduct;
    [SerializeField]
    private bool _removeProduct;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        AddOperation();
        RemoveOperation();

    }

    //Condiciones de los buleanos
    private void AddOperation()
    {
        if (_addProduct == true)
        {

            Addition(_unidadesBrecol, _unidadesPatata);
        }
       
        else
        {
            Debug.Log("Activa casilla para obtener resultado.");
        }
    }


    //Método para la suma
    private void Addition(int brecol, int patata)
    {
        int result = brecol + patata;

        Debug.Log("La suma de las unidades de Brécol y Patata son: " + result);
    }


    private void RemoveOperation()
    {
        if (_removeProduct == true)
        {
            Remove(_unidadesBrecol, _unidadesPatata);
                    
        }
        else
        {
            Debug.Log("Activa casilla para obtener resultado.");
        }
    }
        
    //Método para la resta
    private void Remove(int brecol, int patata)
    {
        int resultRemove = brecol - patata; 

        Debug.Log("La resta de las unidades de Brécol y Patata son: " + resultRemove);
    }

}
