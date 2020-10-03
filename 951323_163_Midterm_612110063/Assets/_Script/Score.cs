using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Text Stage1gamescore;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Stage1gamescore.text = Stage1GameManager.score.ToString("Stage 1 Score " + "0");
    }
}
