using UnityEngine;

public class AntMovement : MonoBehaviour
{
    //Variables globales
    //Puntos de patrulla
    [SerializeField]
    private Transform[] _wayPointsArray;
    [SerializeField]
    private Vector2[] _positionsArray;
    [SerializeField] 
    private Vector3 _posToGo;
    private int _index;
    private SpriteRenderer _spriteRendered;
    private Animator _anim;
    [SerializeField]
    private GameObject _player;

    //Velocidades
    private float _speed;
    [SerializeField]
    private float _speedWalking;
    [SerializeField]
    private float _speedAttack;
    [SerializeField]
    private float _speedAnimation;
    [SerializeField]
    private float _distanceToPlayer;

    private void Awake()
    {

        _speed = _speedWalking;
        _spriteRendered = GetComponent<SpriteRenderer>();
        _anim = GetComponent<Animator>();


        //Creamos el array y hacemos un búcle para la patrulla del Enemy
        _positionsArray = new Vector2[_wayPointsArray.Length];
        for (int i = 0; i < _wayPointsArray.Length; i++) 
        {
            _positionsArray[i] = _wayPointsArray[i].position;
        }

        _posToGo = _positionsArray[0];

    }

  

    // Update is called once per frame
    void Update()
    {
        //Enemy detecta al Player con el Raycast
        Debug.DrawLine(transform.position, _player.transform.position, Color.red);
        if(Vector2.Distance(transform.position, _player.transform.position) <= _distanceToPlayer)
        {
            AttackPlayer();

        }
        else
        {
            ChangeTargetPos();
        }

        

        transform.position = Vector3.MoveTowards(transform.position, _posToGo, _speed * Time.deltaTime);

        Flip();
    }

    private void ChangeTargetPos()
    {
        _speed = _speedWalking;
        _anim.speed = 1.0f;

        //si llegamos al destino
        if (transform.position == _posToGo)
        {
            if (_index == _positionsArray.Length - 1)
            {
                _index = 0;
            }
            else
            {
                _index++;
            }

            //cajón 1 en el elemento 0
            _posToGo = _positionsArray[_index];
        }
    }


    //Volteo de sprite del Enemy
    private void Flip()
    {

        if (_posToGo.x > transform.position.x)
        {
            _spriteRendered.flipX = true;//hacia la derecha
        }
        else if (_posToGo.x < transform.position.x)
        {
            _spriteRendered.flipX = false;//hacia la izquierda
        }
    }

    //Si detecta al Player acelera, tambien la animación
    public void AttackPlayer()
    {
        _speed = _speedAttack;
        _anim.speed = _speedAnimation;
        _posToGo = new Vector2(_player.transform.position.x, _posToGo.y);
    }


    //Recogemos info de si Enemy toca al Player, si es así, aplica daño
    private void OnCollisionEnter2D(Collision2D infoCollision)
    {
        
        if(infoCollision.collider.CompareTag("Player") && 
            infoCollision.collider.GetComponent<VitaminiMovement>().IsGrounded)
        {
            infoCollision.collider.GetComponent<VitaminiHealth>().TakeDamage(25.0f);
        }
        


    }
   

}
