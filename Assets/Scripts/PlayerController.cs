using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int speed = 350;
    private CharacterController _controller;
    private Vector3 _moveDirection;

    private void Awake() {
        _controller = GetComponent<CharacterController>();    
    }

    private void Update() {
        _moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        _controller.Move(_moveDirection * speed / 10 * Time.deltaTime);

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Throw Food");
        }
    }
}
