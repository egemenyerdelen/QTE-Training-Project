using UnityEngine;
using UnityEngine.EventSystems;

public class QteButtons : MonoBehaviour, IPointerDownHandler
{
    private QteButtonsPanel _qteButtonsPanel;

    private void Start()
    {
        _qteButtonsPanel = GetComponentInParent<QteButtonsPanel>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // Force player to click buttons by order
        if (gameObject.name == $"{_qteButtonsPanel.order}")
        {
            gameObject.SetActive(false);
            _qteButtonsPanel.order++;
            if (gameObject.name == "4")
            {
                GameManager.Instance.isSuperActive = false;
                if (GameManager.Instance.remainLife <= 2)
                {
                    GameManager.Instance.remainLife++;
                }
            }
        }
    }
}
    