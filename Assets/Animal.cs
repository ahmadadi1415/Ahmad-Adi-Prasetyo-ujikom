using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] private int _hungerNeed, _score, _speed;
    [SerializeField] private int _currentHunger;
    [SerializeField] private string animation;
    [SerializeField] private Vector3 _targetPosition;

    private void Start()
    {
        _targetPosition = new Vector3(transform.position.x, transform.position.y, -1);
    }

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        var step = _speed / 50 * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, step);

        if (Vector3.Distance(transform.position, _targetPosition) < 0.1f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            Debug.Log("FOOOOD");
            _currentHunger += other.gameObject.GetComponent<FoodController>()._hungerValue;

            if (_currentHunger >= _hungerNeed)
            {
                Destroy(gameObject);
            }

            Destroy(other.gameObject);
        }
    }
}
