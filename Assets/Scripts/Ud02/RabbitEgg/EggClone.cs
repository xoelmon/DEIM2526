using UnityEngine;

public class EggClone : MonoBehaviour
{

    //Zona de variables globales
    [SerializeField]
    private GameObject _egg;
    [SerializeField]
    private Transform _posRotRabbit;
    [SerializeField]
    private float _timeDestroy;

    // Update is called once per frame
    void Update()
    {

        CreateEgg();

    }

    private void CreateEgg()
    {
        //Instanciamos los huevos con el botón izquierdo del ratón

        if (Input.GetMouseButtonDown(0))
        {

            GameObject cloneEgg = Instantiate(_egg, _posRotRabbit.position, _posRotRabbit.rotation);

            Destroy(cloneEgg, _timeDestroy);
        }
    }
}
