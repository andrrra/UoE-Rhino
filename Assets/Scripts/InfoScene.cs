using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoScene : MonoBehaviour {
    public void NextScene() {
        SceneManager.LoadScene("Info");
    }
}
