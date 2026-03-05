using TMPro;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField]
    private Transform _player;

    //Distancia entre camera y player
    private Vector3 _offset;
    private Vector3 _smoothDampVelociy;

    //Tiempo de suavizado
    [SerializeField]
    private float _smoothTargetTime;


    private void Awake()
    {
        //Calcula distancia inicial entre camera y player
        _offset = transform.position - _player.position;

    }


    // Update is called once per frame
    void Update()
    {

        MoveCamera();

    }

    //Seguimiento de la cámara al Player
    //Seguimiento de la cámara al Player
    private void MoveCamera()
    {

        transform.position = Vector3.SmoothDamp(transform.position, _player.position
                                    + _offset, ref _smoothDampVelociy, _smoothTargetTime);

    }


}



