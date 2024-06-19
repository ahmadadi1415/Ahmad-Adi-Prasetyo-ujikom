using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private string _targetScene;
    
    public void LoadTargetScene()
    {
        SceneManager.LoadScene(_targetScene);
    }
}
