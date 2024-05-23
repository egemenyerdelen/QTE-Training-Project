using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class FallingObjects : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private int fallSpeed;
    [SerializeField] private int rotationSpeed;
    [SerializeField] private int bottomBoundary;

    private void Update()
    {
        MoveObject();
    }

    private void MoveObject()
    {
        transform.Translate(0, -fallSpeed * Time.deltaTime, 0);
        transform.Rotate(Vector3.down, rotationSpeed * Time.deltaTime);

        var distanceToBottom = transform.position.y - bottomBoundary;

        if (transform.position.y <= bottomBoundary)
        {
            Destroy(gameObject);
            gameManager.remainLife--;
            if (gameManager.remainLife <= 1 && distanceToBottom <= gameManager.saveDistance)
            {
                Time.timeScale = .2f;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
    }

    private void OnMouseDown()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            Destroy(gameObject);
            gameManager.score++;
        }
    }
}
