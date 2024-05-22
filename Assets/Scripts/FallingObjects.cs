using System;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.EventSystems;

public class FallingObjects : MonoBehaviour
{
    [SerializeField] private int fallSpeed;
    [SerializeField] private int rotationSpeed;
    [SerializeField] private int bottomBoundary = -16;
    
    private void Update()
    {
        MoveObject();
    }

    private void MoveObject()
    {
        transform.Translate(0, -fallSpeed * Time.deltaTime, 0);
        transform.Rotate(Vector3.down, rotationSpeed * Time.deltaTime);

        if (transform.position.y <= bottomBoundary)
        {
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            Destroy(gameObject);
        }
    }
}
