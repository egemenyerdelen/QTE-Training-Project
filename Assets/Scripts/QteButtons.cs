using System;
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
        if (gameObject.name == $"{_qteButtonsPanel.order}")
        {
            gameObject.SetActive(false);
            _qteButtonsPanel.order++;
        }
    }
}
    