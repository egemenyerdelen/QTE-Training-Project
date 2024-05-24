using UnityEngine;

public class ObjectDistanceControl : MonoBehaviour
{
    private void Update()
    {
        if (GameManager.Instance.isObjectInSaveDistance && GameManager.Instance.remainLife <= 1)
        {
            Time.timeScale = .2f;
        }
        else if (!GameManager.Instance.isSuperActive)
        {
            Time.timeScale = 1;
        }
    }
}
