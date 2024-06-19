
using UnityEngine;

public class SFXController : MonoBehaviour
{
    [SerializeField] private AudioClip _buttonClicked, _throwFood, _eat, _destroyAnimal;
    [SerializeField] private AudioSource _sfxSource;

    public void PlayButtonClicked()
    {
        _sfxSource.PlayOneShot(_buttonClicked);
    }

    public void PlayThrowFood()
    {
        _sfxSource.PlayOneShot(_throwFood);
    }

    public void PlayEat()
    {
        _sfxSource.PlayOneShot(_eat);
    }

    public void PlayDestroyAnimal()
    {
        _sfxSource.PlayOneShot(_destroyAnimal);
    }
}
