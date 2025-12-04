using UnityEngine;

public class Enemy : MonoBehaviour
{

    private void OnTriggerEnter(Collider infoAccess)
    {
        
        if (infoAccess.CompareTag("AttackPlayer"))
        {

            Destroy(gameObject);

        }

    }



}
