using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitpoints = 100f;
    public void TakeDamage(float Damage)
    {
        BroadcastMessage("OnDamageTaken");
        hitpoints -= Damage;
        if (hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
