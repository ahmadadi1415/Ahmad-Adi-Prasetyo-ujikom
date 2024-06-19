using UnityEngine;

public class FoodController : MonoBehaviour
{
    [SerializeField] private float _lifetime = 3;
    [SerializeField] private Vector3 _targetPosition;
    private Rigidbody _rigidbody;
    private float currentTimer = 3;

    private void Awake() {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _rigidbody.Move(new Vector3(transform.position.x, transform.position.y, _targetPosition.z), Quaternion.identity);
        
        if (currentTimer > 0.01f)
        {
            currentTimer -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Move()
    {
        _rigidbody.Move(new Vector3(transform.position.x, transform.position.y, _targetPosition.z), Quaternion.identity);
    }
}
