using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour, IEnemy
{
    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] private Transform _moveTarget;
    [SerializeField] private float _health;

    void Start()
    {

    }

    void Update()
    {
        if (_moveTarget)
        {
            _agent.SetDestination(_moveTarget.position);
        }
    }

    public void TakeDamage(float dmg)
    {
        _health -= dmg;

        if (_health <= 0)
        {
            gameObject.SetActive(false);
            Die();
            GameManager.instance.TriggerGameOver();
        }
    }
    private void Die()
    {
        GameManager.instance.TriggerGameOver();
        Destroy(gameObject);  // Destroy the character
    }
}

public interface IEnemy
{
    void TakeDamage(float dmg);
}