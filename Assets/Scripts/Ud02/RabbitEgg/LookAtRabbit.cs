using UnityEngine;

public class LookAtRabbit : MonoBehaviour
{
    //zona de variables globales
    [SerializeField]
    private Transform _rabbit;

  

    // Update is called once per frame
    void Update()
    {

        LookRabbit();

    }

    private void LookRabbit()
    {

        transform.LookAt( _rabbit );

    }
}
