using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    [SerializeField] private float _lifetime = 3;
    private float currentTimer =  3;

    private void Update() {
        if (currentTimer > 0.01f)
        {
            currentTimer -= Time.deltaTime;
        }
        else {
            Destroy(gameObject);
        }
    }
}
