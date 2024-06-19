using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private AudioManager _audioManager;
    [SerializeField] private SceneController _scene;
    
    public void OnPlayButtonClicked()
    {
        _audioManager.PlayButtonClicked();
        _scene.LoadTargetScene();
    }
}
