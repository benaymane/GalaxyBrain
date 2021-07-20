using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {
    public void loadNextScene() {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex + 1);
    }

    public void changePanelVisibility(GameObject panel) {
        bool activeStatus = panel.activeSelf;
        panel.SetActive(!activeStatus);
    }
}
