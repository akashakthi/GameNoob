using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public event Action boosDie;
    public event Action stageFinish;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) 
        { 
         stagefinish();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            BossDie();
        }

    }

    void stagefinish()
    {
        if (stageFinish != null)
        {
            stageFinish.Invoke();
        }
    }

    private void BossDie()
    {
        if(boosDie != null)
        {
            boosDie.Invoke();
        }
    }
}
