using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public float delay = 3f;
    private float timer;
    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= delay)
        {
            SwitchToMainGameScene();
        }
    }
    private void SwitchToMainGameScene()
    {
        SceneManager.LoadScene("MainGame");
    }
}
