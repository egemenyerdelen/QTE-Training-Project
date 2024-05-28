using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
}
