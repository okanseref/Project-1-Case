using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    [SerializeField] private GameObject objectPrefab;
    private Queue<GameObject> queue;

    private void Start()
    {
        this.queue = new Queue<GameObject>();
        for (int i = 0; i < 10; i++)
        {
            CreateNewObject();
        }
    }
    public void ReturnObject(GameObject objectReturned)
    {
        objectReturned.SetActive(false);
        queue.Enqueue(objectReturned);
    }
    public void CreateNewObject()
    {
        GameObject newObject = Instantiate(objectPrefab, null);
        newObject.SetActive(false);
        queue.Enqueue(newObject);
    }
    public GameObject GetObject()
    {
        if (queue.Count < 3)
        {
            CreateNewObject();
        }
        return queue.Dequeue();
    }
}
