using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource _sfxSource;

    public void PlayButtonClicked()
    {
        _sfxSource.Play();
    }

    
}
