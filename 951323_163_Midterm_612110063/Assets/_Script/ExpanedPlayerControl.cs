﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExpanedPlayerControl : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < -1f)
        {
            Invoke("Dead", 2f);
            
        }
    }
    public void Dead()
    {
        SceneManager.UnloadScene("SceneGameplayStage1");
        SceneManager.LoadScene("SceneMainMenu");
    }

    

   

}
