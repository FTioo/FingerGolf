using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] TMP_Text gameOverText;
    [SerializeField] PlayerController player;
    [SerializeField] Hole hole;
    private void Start() {
        gameOverPanel.SetActive(false);
    }

    private void Update() {
        if(hole.Entered && gameOverPanel.activeInHierarchy == false){
            gameOverPanel.SetActive(true);
            gameOverText.text = "Finished! Shoot count : " + player.ShootCount;
        }
    }

    public void BackToMainMenu(){
        SceneLoader.Load("MainMenu");
    }
    public void Replay(){
        SceneLoader.ReloadLevel();
    }
    public void PlayNext(){
        SceneLoader.LoadNextLevel();
    }
    public static void LoadAddictive(string sceneName){
        SceneLoader.LoadAddictive(sceneName);
    }
    public static void UnloadAddictive(string sceneName){
        SceneLoader.UnloadAddictive(sceneName);
    }
}
