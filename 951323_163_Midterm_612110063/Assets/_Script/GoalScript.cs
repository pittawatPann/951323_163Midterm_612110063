using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            StageClear();
            Destroy(this.gameObject);
        }
    }
    void StageClear()
    {
        if (SingletonSoundManager.Instance.BGMSource.isPlaying)
            SingletonSoundManager.Instance.BGMSource.Stop();
        SceneManager.UnloadSceneAsync("SceneGameplayStage1");
        SceneManager.LoadScene("SceneGameplayStage2");
    }
}
