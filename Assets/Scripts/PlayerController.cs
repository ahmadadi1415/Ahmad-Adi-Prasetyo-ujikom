using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int speed = 350;
    private Vector3 _moveDirection;
    private CharacterController _controller;
    [SerializeField] private Animator _animator;
    
    private void Awake() {
        _controller = GetComponent<CharacterController>();    
    }

    private void Update() {
        _moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        _controller.Move(_moveDirection * speed / 10 * Time.deltaTime);

        _animator.SetBool("isMoving", _moveDirection != Vector3.zero);
        _animator.SetFloat("horizontalMovement", _moveDirection.x);

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Throw Food");
            _animator.SetTrigger("throw");
        }
    }
}
