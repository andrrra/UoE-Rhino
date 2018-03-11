using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour {
    public void NextScene() {
        SceneManager.LoadScene("Main");
    }
}
