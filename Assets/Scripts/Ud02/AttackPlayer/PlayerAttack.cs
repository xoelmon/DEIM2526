using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    //Variables globales
    private Animator _anim;

    [SerializeField]
    private Collider  _colliderAttack;


    //Para comenzar con el collider desactivado
    private void Start()
    {
        _colliderAttack.enabled = false;
    }


    private void Awake()
    {
       //Obtenemos el componenete
        _anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        InputAttack();
    }


    private void InputAttack()
    {
        //Método para recoger el botón inputs
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    private void Attack()
    {
        //Método para la realizar la acción
        _anim.SetTrigger("Attack");
    }

    private void OnEnable()
    {
        //habilito componente
        _colliderAttack.enabled = true;

    }


    private void OnDisable()
    {
        //Deshabilito componente
        _colliderAttack.enabled = false;

    }

}


