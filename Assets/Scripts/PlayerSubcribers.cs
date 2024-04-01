using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSubcribers : MonoBehaviour
{
    public GameManager gameManager;

    private void OnEnable()
    {
        gameManager.stageFinish += SalamDuaJari;
    }

    private void OnDisable()
    {
        gameManager.stageFinish -= SalamDuaJari;
    }

    void SalamDuaJari()
    {
        print("Oke Gas No 2 torang Gass!!");
    }
}
