using UnityEngine;

public class FoodController : MonoBehaviour
{
    [SerializeField] private float _lifetime = 3;
    [SerializeField] private float __speed = 300;
    [SerializeField] private Vector3 _targetPosition;
    private Rigidbody _rigidbody;
    private float currentTimer = 3;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        _targetPosition = new Vector3(transform.position.x, transform.position.y, 100);
    }

    private void Update()
    {
        Move();

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
        var step = __speed / 10 * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, step);
    }
}
