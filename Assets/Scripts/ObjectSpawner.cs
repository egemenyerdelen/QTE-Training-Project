using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private int height = 8;
    [SerializeField] private int width = 5;
    [SerializeField] private int repeatInterval = 1;
    [SerializeField] private GameObject[] objectsToFall;
    
    private void Start()
    {
        InvokeRepeating(nameof(ObjectSpawn), 1f, repeatInterval);
    }

    private void ObjectSpawn()
    {
        float randomX = Random.Range(-width, width);
        var spawnPosition = new Vector3(randomX, height);
        var spawnNumber = Random.Range(0, objectsToFall.Length);

        Instantiate(objectsToFall[spawnNumber], spawnPosition, Quaternion.identity);
    }
}
