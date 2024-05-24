using UnityEngine;
public class UI : MonoBehaviour
{
    public static UI Instance;

    [SerializeField] private GameObject gameOverPanel;
    
    public void Awake()
    {
        Instance = this;
    }

    public void OpenGameOverPanel()
    {
        gameOverPanel.SetActive(true);
    }
}
