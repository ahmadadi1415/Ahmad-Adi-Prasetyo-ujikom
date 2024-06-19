using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float _gameTime = 60;
    private float _currentTimer = 60;
    public bool GameOver = false;

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
}
