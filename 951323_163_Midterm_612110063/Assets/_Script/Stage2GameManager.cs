using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage2GameManager : MonoBehaviour
{
    public Text text2;
    public Text ScoreText;
    public static float _Time2 = 20;
    public static float score;
    private float Timeleft;
    private float scorebyTime;
    public  static float scorebyItem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text2.text = _Time2.ToString("F0");
        _Time2 = _Time2 - Time.deltaTime;
        Timeleft = _Time2;
        if(_Time2 <= 0)
        {
            Dead2();
        }
        scorebyTime = Timeleft * 1000;
        score = scorebyTime + scorebyItem;
        ScoreText.text = score.ToString("F0");
    }

    public void Dead2()
    {
        SceneManager.UnloadScene("SceneGameplayStage1");
        SceneManager.LoadScene("SceneMainMenu");
    }
}
