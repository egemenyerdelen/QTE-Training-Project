using UnityEngine;
using UnityEngine.EventSystems;

public class FallingObjects : MonoBehaviour
{
    [SerializeField] private int fallSpeed;
    [SerializeField] private int rotationSpeed;
    [SerializeField] private int bottomBoundary;
    [SerializeField] private int saveDistance = -2;

    private void Update()
    {
        MoveObject();
    }

    private void MoveObject()
    {
        transform.Translate(0, -fallSpeed * Time.deltaTime, 0);
        transform.Rotate(Vector3.down, rotationSpeed * Time.deltaTime);

        if (transform.position.y <= saveDistance)
        {
            GameManager.Instance.isObjectInSaveDistance = true;
        }
        
        if (transform.position.y <= bottomBoundary)
        {
            Destroy(gameObject);
            GameManager.Instance.isObjectInSaveDistance = false;
            GameManager.Instance.remainLife--;
        }
    }

    private void OnMouseDown()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            Destroy(gameObject);
            GameManager.Instance.isObjectInSaveDistance = false;
            GameManager.Instance.score++;
        }
    }
}
