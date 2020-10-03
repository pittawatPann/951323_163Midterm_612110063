using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelectMenuControlScript : MonoBehaviour
{
    [SerializeField] Button backButton;
    [SerializeField] Button Stage1Button;
    [SerializeField] Button Stage2Button;
    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener
            (delegate { BackToMainMenuButtonClick(backButton); });
        Stage1Button.onClick.AddListener
            (delegate { BackToMainMenuButtonClick(Stage1Button); });
        Stage2Button.onClick.AddListener
            (delegate { BackToMainMenuButtonClick(Stage2Button); });
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BackToMainMenuButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneStageSelect");
        SceneManager.LoadScene("SceneMainMenu");
    }
}
