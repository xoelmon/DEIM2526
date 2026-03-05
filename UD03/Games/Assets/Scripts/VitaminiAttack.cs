using UnityEngine;

public class VitaminiAttack : MonoBehaviour
{

    //Variable globales
    [SerializeField]
    private VitaminiMovement _vitaminimovementScript;
    [SerializeField] 
    private float _jumpForce;



    //Recogemos info de cuando Player colisiona con Enemy
    private void OnCollisionEnter2D(Collision2D infoCollision)
    {
        if (infoCollision.collider.CompareTag("Ant"))
        {

            AttackEnemy(infoCollision.gameObject);

        }

    }

    private void AttackEnemy(GameObject enemy)
    {
        if (_vitaminimovementScript.IsGrounded)
        {
            return;

        }

        //Al saltar en Enemy recibimos impulso
        _vitaminimovementScript.Rb.AddForce(Vector2.up * _jumpForce);

        //Activamos animación de muerte en Enemy y destruimos
        enemy.GetComponent < Animator>().SetTrigger("Death");
        Destroy(enemy, 0.3f);

    }
}
