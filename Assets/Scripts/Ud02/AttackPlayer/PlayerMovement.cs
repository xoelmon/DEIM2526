using System.IO;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Variable globales
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _turnSpeed;

    //Las hacemos globales para poder usarlas en distintos métodos
    private float _horizontal;
    private float _vertical;

    //Creamos variable para acceder al Animator
    //Creamos Ray con su info y layer
    private Animator _anim;
    private Ray _ray;
    private RaycastHit _hit;
    [SerializeField]
    private float _rayLenth;
    [SerializeField]
    private LayerMask _rayMask;

    //Accedemos a Rigidbody
    private Rigidbody _rb;
    [SerializeField]
    private float _forceJump;
    private bool _isGrounded;
    private bool _canJumg;

    private void Awake()
    {   
        //Mi variable _anim apunta al componente Animator
        _anim = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        
        LaunchRaycast();
        if(_canJumg == true)
        {
            _canJumg = false;
            Jump();
        }
    }

    // Update is called once per frame
    void Update()
    {
        InputsPlayer();
        Move();
        Turn();
        Animating();
        CanJump();

    }


    private void LaunchRaycast()
    {
        //colocamos origen y dirección del rayo
        _ray.origin = transform.position;
        _ray.direction = -transform.up;

        if (Physics.Raycast(_ray, out _hit, _rayLenth, _rayMask))
        {
            Debug.Log("toco el suelo");
            _isGrounded = true;
        }
        else 
        {
            _isGrounded= false; 
        
        }
    }

    private void CanJump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && _isGrounded == true)
        {
            _canJumg = true;
        }
    }


    private void Jump()
    {
        _rb.AddForce(Vector3.up * _forceJump);
    }
    


    //Recogemos información información ejes
    private void InputsPlayer()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
    }

    //Recoger la translación del player
    private void Move()
    {
        transform.Translate(Vector3.forward * _speed * _vertical * Time.deltaTime);

    }

    //Recoger la rotación del player
    private void Turn()
    {

        transform.Rotate(Vector3.up * _turnSpeed * _horizontal * Time.deltaTime);
    }

    private void Animating()
    {   
        //El player se mueve
        if (_vertical != 0)
        {
            _anim.SetBool("IsMove", true);
        }
        else
        {
            _anim.SetBool("IsMove", false);
        }
    }

}

