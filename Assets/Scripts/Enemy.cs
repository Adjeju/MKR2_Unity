using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float movementSpeed = 5f;
    public Transform target; 
    public float detectionDistance = 3f;
    public GameObject panel;

    private void Update()
    {
        Vector3 direction = target.position - transform.position;
        direction.Normalize();

        transform.Translate(direction * movementSpeed * Time.deltaTime);

        float distanceToPlayer = Vector3.Distance(transform.position, target.position);

        if (distanceToPlayer < detectionDistance)
        {
            panel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
