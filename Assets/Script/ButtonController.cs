﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {
    public void loadNextScene() {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(++sceneIndex < SceneManager.sceneCountInBuildSettings) {
            SceneManager.LoadScene(sceneIndex);
        }
    }

    public void changePanelVisibility(GameObject panel) {
        if(panel != null) {
            bool activeStatus = panel.activeSelf;
            panel.SetActive(!activeStatus);
        }
    }
}
