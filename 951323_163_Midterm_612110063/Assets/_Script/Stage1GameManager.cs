using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage1GameManager : MonoBehaviour
{
    public Text text;
    public Text ScoreText;
    public float _Time = 30;
    public static float score;
    private float Timeleft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = _Time.ToString("F0");
       
        _Time = _Time - Time.deltaTime;
        Timeleft = _Time;
        if(_Time <= 0)
        {
            Dead();
        }

        score = Timeleft * 1000;
        ScoreText.text = score.ToString("F0");
    }

    public void Dead()
    {
        SceneManager.UnloadScene("SceneGameplayStage1");
        SceneManager.LoadScene("SceneMainMenu");
        
    }
}
