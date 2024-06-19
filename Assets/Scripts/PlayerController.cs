using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int _speed = 350;
    [SerializeField] private GameObject _foodObject;
    private Vector3 _moveDirection;
    private CharacterController _controller;
    [SerializeField] private Animator _animator;
    private Transform _transform;

    private void Awake() {
        _controller = GetComponent<CharacterController>();    
        _transform = transform;
    }

    private void Update() {
        _moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        _controller.Move(_moveDirection * _speed / 10 * Time.deltaTime);

        _animator.SetBool("isMoving", _moveDirection != Vector3.zero);
        _animator.SetFloat("horizontalMovement", _moveDirection.x);

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Throw Food");
            _animator.SetTrigger("throw");

            GameObject.Instantiate(_foodObject, _transform.position, Quaternion.identity);
        }
    }
}
