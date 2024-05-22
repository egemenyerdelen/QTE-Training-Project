using UnityEngine;
using UnityEngine.EventSystems;

public class QteButtons : MonoBehaviour, IPointerDownHandler
{
    private void Update()
    {
        
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        {
            gameObject.SetActive(false);
        }
    }
}
    