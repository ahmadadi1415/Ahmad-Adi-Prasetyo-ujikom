using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float _gameTime = 60;
    private float _currentTimer = 60;
    public bool GameOver = false;
    [SerializeField] private GameObject _pauseView;

    private void Update()
    {
        if (_currentTimer > 0.01f)
        {
            GameOver = false;
            _currentTimer -= Time.deltaTime;
        }
        else
        {
            GameOver = true;
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        _pauseView.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        _pauseView.SetActive(false);
    }

    public void OnMainMenuClicked()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
