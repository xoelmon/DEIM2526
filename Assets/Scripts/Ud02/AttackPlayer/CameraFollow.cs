using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    //Variables globales
    //Objetivo a seguir
    [SerializeField]
    private Transform _target;
    
    //Velocidad seguimiento
    [SerializeField]
    private float _smoothing;

    //Distancia entre cámara y player
    [SerializeField]
    private Vector3 _offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _offset = transform.position - _target.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Posición a la que se mueve la cámara
        Vector3 desiredPosition = _target.position + _offset;

        //Mover la cámara
        transform.position = Vector3.Lerp(transform.position, desiredPosition, _smoothing * Time.deltaTime);

    }
}
