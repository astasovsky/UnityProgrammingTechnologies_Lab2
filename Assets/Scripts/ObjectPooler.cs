using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler SharedInstance;

    [SerializeField] private GameObject objectToPoolPrefab;
    [SerializeField] private int amountToPool;

    private List<GameObject> _pooledObjects;

    private void Awake()
    {
        SharedInstance = this;
    }

    // Start is called before the first frame update
    private void Start()
    {
        // Loop through list of pooled objects,deactivating them and adding them to the list 
        _pooledObjects = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            CreateNewGameObject();
        }
    }

    public GameObject GetPooledObject()
    {
        // For as many objects as are in the pooledObjects list
        foreach (GameObject pooledObject in _pooledObjects)
        {
            // if the pooled objects is NOT active, return that object 
            if (!pooledObject.activeInHierarchy)
            {
                return pooledObject;
            }
        }

        return CreateNewGameObject();
    }

    private GameObject CreateNewGameObject()
    {
        GameObject obj = Instantiate(objectToPoolPrefab, transform, true);
        obj.SetActive(false);
        _pooledObjects.Add(obj);
        return obj;
    }
}