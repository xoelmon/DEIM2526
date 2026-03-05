using UnityEngine;
using UnityEngine.UI;

public class VitaminiHealth : MonoBehaviour
{

    //Variables globales
    [Header("Health")]
    [SerializeField]
    private float _maxHealth;
    [SerializeField]
    private float _currentHealth;

    [Header("UI")]
    [SerializeField]
    private Image _acorn;
    [SerializeField]
    private float _amountLife;

    [Header("Death")]
    [SerializeField]
    private float _forceJumpDeath;

    private Animator _anim;
    public VitaminiMovement _vitaminiMovementScript;

    
    void Awake()
    {
        
        _anim = GetComponent<Animator>();
        _vitaminiMovementScript = GetComponent<VitaminiMovement>(); 

        _currentHealth = _maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float amount)
    {

        if(_anim.GetBool("IsHurt") == true || _currentHealth <= 0.0f)
        {
            return;
        }


        _currentHealth -= amount;
        _acorn.fillAmount = _currentHealth / _maxHealth;
        _anim.SetBool("IsHurt", true);
        _vitaminiMovementScript.ResetVelocity();


        if (_currentHealth <= 0.0f)
        {
            Death();
            return;
        }

        Invoke("HurtToFalse", 1.0f);

    }

    private void HurtToFalse()
    {
        _anim.SetBool("IsHurt", false);
    }


    private void Death()
    {

        GetComponent<CircleCollider2D>().enabled = false;
        GetComponent<Rigidbody>().AddForce(Vector2.down *  _forceJumpDeath);

    }


}
