using UnityEngine;

public class QteButtonsPanel : MonoBehaviour
{
    public int order = 1;
    
    [SerializeField] private QteButtons[] qteButtons;

    private BoxCollider2D _buttonBounds;
    private int _superThreshold;
    private int _thresholdMultiplier = 1;
    private void Start()
    {
        qteButtons = GetComponentsInChildren<QteButtons>(true);
        _buttonBounds = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        ActivateSuperPower();
    }

    private void OpenButtonPanel()
    {
        // Spawn buttons inside a collider
        foreach (var button in qteButtons)
        {
            var randomX = Random.Range(_buttonBounds.bounds.min.x, _buttonBounds.bounds.max.x);
            var randomY = Random.Range(_buttonBounds.bounds.min.y, _buttonBounds.bounds.max.y);
            
            button.transform.position = new Vector3(randomX, randomY);
            button.gameObject.SetActive(true);
        }
    }

    private void ActivateSuperPower()
    {
        _superThreshold = 10 * _thresholdMultiplier;
        GameManager.Instance.canSuperEnable = GameManager.Instance.score >= _superThreshold;
        if (GameManager.Instance.canSuperEnable && !GameManager.Instance.isSuperActive)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                order = 1;
                Time.timeScale = .3f;
                GameManager.Instance.isSuperActive = true;
                OpenButtonPanel();
                _thresholdMultiplier++;
            }
        }
    }
}
