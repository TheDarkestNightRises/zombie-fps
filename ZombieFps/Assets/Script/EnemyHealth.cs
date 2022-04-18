using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitpoints = 100f;
    bool isDead = false;
    public bool IsDead()
    {
        return isDead;
    }

    public void TakeDamage(float Damage)
    {
        BroadcastMessage("OnDamageTaken");
        hitpoints -= Damage;
        if (hitpoints <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if (isDead) return;
        isDead = true;
        GetComponent<Animator>().SetTrigger("die");
    }
}
