using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private AudioManager _audioManager;
    [SerializeField] private SceneController _scene;

    public void OnPlayButtonClicked()
    {
        _audioManager._sfxController.PlayButtonClicked();
        _scene.LoadTargetScene();
    }
}
