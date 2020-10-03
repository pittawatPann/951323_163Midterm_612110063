using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameplayMenuControlScript : MonoBehaviour
{
    [SerializeField] Button _backButton;
    [SerializeField] Button struckButton;
    // Start is called before the first frame update
    void Start()
    {
        _backButton.onClick.AddListener
            (delegate { BackToMainMenuButtonClick(_backButton); });
        struckButton.onClick.AddListener
            (delegate { StruckButtonClick(struckButton); });
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BackToMainMenuButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneGameplayStage1");
        SceneManager.LoadScene("SceneStageSelect");
    }
    public void StruckButtonClick(Button button)
    {
        SceneManager.LoadScene("SceneGameplayStage1");
    }
}
