using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class UI : MonoBehaviour
{
    public static UI Instance;
    
    [SerializeField] private QteButtons[] qteButtons;
    
    public void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        qteButtons = GetComponentsInChildren<QteButtons>(true);
        OpenButtonPanel();

    }

    private void Update()
    {
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
