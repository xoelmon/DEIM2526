using UnityEditor.Tilemaps;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class VitaminiMovement : MonoBehaviour
{
    //Variables globales
    [Header("Velocity")]
    [SerializeField]
    private float _speed;
    //Aceleración
    [SerializeField]
    private float _smoothTime;

    public Rigidbody2D Rb;
    private Animator _anim;
    private SpriteRenderer _spriteRendered;

    //Velocidad del player
    private Vector2 _targetVelocity;
    private Vector2 _dampVelocity;

    //VAriables de salto
    [Header("Jump")]
    [SerializeField]
    private float _jumpForce;
    private bool _jumpPressed;

    [Header("Raycast")]
    //Punto de origen
    [SerializeField]
    private Transform _groundCheck;
    //Capa del suelo
    [SerializeField]
    private LayerMask _groundLayer;
    //Longitud del raycast
    [SerializeField]
    private float _rayLenth;
    //¿Tocamos el suelo?

    [Header("Acorn")]
    [SerializeField]
    private int _numAcorns;
    [SerializeField]
    private TextMeshProUGUI _textAcornUI;

    public bool IsGrounded;


    void Awake()
    {
        //Cogemos los componentes y activamos el texto del canva
        _textAcornUI.text = "Lost Acorns: " + _numAcorns.ToString();
        _jumpPressed = false;
        Rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _spriteRendered = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        Move();
        CanJump();
        RaycastGrounded();
        ChangeGravity();
    }

    // Update is called once per frame
    void Update()
    {
        InputsPlayer();

        //Activamos animación de muerte y repetimos escena en caso de
        //caer respectivamente por debajo de -2 y -8
        if (Rb.position.y < -2.0f)
        {
            _anim.SetBool("IsHurt", true);           
        }
        if (Rb.position.y < -12.0f)
        {
            GetNewScene();
        }
    }

    private void InputsPlayer()
    {
        //Recogemos ejes para movimiento y asignamos space para salto
        float horizontal = Input.GetAxis("Horizontal");
        _targetVelocity = new Vector2(horizontal * _speed, Rb.linearVelocity.y);

        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded == true)
        {
            _jumpPressed = true;
        }

        Flip(horizontal);
        Animating(horizontal);

    }


    public void ResetVelocity()
    {
        _targetVelocity = Vector2.zero;
    }

    private void Move()
    {

        Rb.linearVelocity = Vector2.SmoothDamp(Rb.linearVelocity, _targetVelocity, ref _dampVelocity, _smoothTime);

    }

    //etodo para activar las diferentes animaciones
    private void Animating(float h)
    {
        if(h != 0.0f)
        {

            _anim.SetBool("IsRunning", true);
        }

        else
        {

            _anim.SetBool("IsRunning", false);
        }

        _anim.SetBool("IsJumping", !IsGrounded);

    }

    //Método para voltear es sprite 
    private void Flip(float h)
    {
        if (h > 0.0f)
        {
            _spriteRendered.flipX = false;
        }
        else if (h < 0.0f)
        {
            _spriteRendered.flipX = true;
        }
    }

    //Métodos para el salto, solo salta cuando detecta el suelo
    private void CanJump()
    {
        if(_jumpPressed == true)
        {
            Jump();
        }
    }

    private void Jump()
    {
        _jumpPressed = false;
        Rb.AddForce(Vector2.up * _jumpForce);
    }

    //Diferencia de gravedad al caer después del salto
    private void ChangeGravity()
    {

        if(Rb.linearVelocity.y < 0.0f)
        {
            Rb.gravityScale = 2.3f;
        }
        else
        {
            Rb.gravityScale = 1.0f;
        }
    }

    //Detención del suelo para realizar el salto
    private void RaycastGrounded()
    {
        IsGrounded = Physics2D.Raycast(_groundCheck.position, Vector2.down, _rayLenth, _groundLayer);

        Debug.DrawRay(_groundCheck.position, Vector2.down * _rayLenth, Color.red);
    }


    //Detectar las bellotas para poder recogerlas, con array, al ternimarlas,
    //repetimos la escena
    private void OnCollisionEnter2D(Collision2D infoCollision)
    {

        if (infoCollision.collider.CompareTag("Acorn"))
        {

            Destroy(infoCollision.gameObject);
            _numAcorns--;
            _textAcornUI.text = "Lost Acorns: " + _numAcorns.ToString();


            if( _numAcorns == 0)
            {
                GetNewScene();
            }
        }

    }

    //Repetimos la escena
    private void GetNewScene()
    {
        SceneManager.LoadScene(0);
    }

}

