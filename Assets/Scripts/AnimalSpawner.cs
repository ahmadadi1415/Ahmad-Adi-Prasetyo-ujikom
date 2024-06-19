using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    [SerializeField] private Vector3 _startPosition = new Vector3(-5, -1, 50);
    [SerializeField] private Vector3 _endPosition = new Vector3(5, -1, 50);
    [SerializeField] private Vector3 _targetPosition;
    [SerializeField] private float _speed = 10;
    [SerializeField] private float _spawnInterval = 2;
    [SerializeField] private GameObject[] animals;
    [SerializeField] private GameManager _gameManager;
    private float _currentTimer = 2;

    private void Start()
    {
        _targetPosition = _startPosition;
        transform.position = _startPosition;
    }

    private void Update()
    {
        if (_gameManager.GameOver) return;
        Move();
        Spawn();
    }


    private void Spawn()
    {
        if (_currentTimer < 0.01f)
        {
            // DO: Spawn random animal
            int random = Random.Range(0, 4);
            GameObject selected = animals[random];

            GameObject animal = GameObject.Instantiate(selected, transform.position, Quaternion.identity);
            _currentTimer = _spawnInterval;
        }
        else
        {
            _currentTimer -= Time.deltaTime;
        }
    }

    private void Move()
    {
        if (Vector3.Distance(transform.position, _targetPosition) < 0.1f)
        {
            if (_targetPosition == _startPosition)
            {
                _targetPosition = _endPosition;
            }
            else if (_targetPosition == _endPosition)
            {
                _targetPosition = _startPosition;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);
    }
}
