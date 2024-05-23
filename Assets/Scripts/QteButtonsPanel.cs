using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QteButtonsPanel : MonoBehaviour
{
    public int order = 1;
    
    [SerializeField] private QteButtons[] qteButtons;
    private void Start()
    {
        qteButtons = GetComponentsInChildren<QteButtons>(true);
        OpenButtonPanel();
    }

    private void OpenButtonPanel()
    {
        var buttonBounds = GetComponent<BoxCollider2D>();
        foreach (var button in qteButtons)
        {
            var randomX = Random.Range(buttonBounds.bounds.min.x, buttonBounds.bounds.max.x);
            var randomY = Random.Range(buttonBounds.bounds.min.y, buttonBounds.bounds.max.y);
            
            button.transform.position = new Vector3(randomX, randomY);
            button.gameObject.SetActive(true);
        }
    }
}
