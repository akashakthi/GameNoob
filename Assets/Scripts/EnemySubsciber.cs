using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySubsciber : MonoBehaviour
{
    public GameManager gameManager;

    private void OnEnable()
    {
        gameManager.boosDie += DestroyEnemy;
    }

    private void OnDisable()
    {
        gameManager.boosDie -= DestroyEnemy;
    }

    void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}
