using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolManager : MonoBehaviour
{
    public static ObjectPoolManager instance;

    public List<GameObject> pooledObject = new List<GameObject>();
    private int amountToPool = 8;

    [SerializeField] private GameObject spikePF;

    // Start is called before the first frame update
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    private void Start()
    { 
        for(int i = 0 ;i< amountToPool; i++)
        {
            GameObject obj = Instantiate(spikePF);
            obj.SetActive(false);
            pooledObject.Add(obj);
        }
    }
  
    public GameObject GetPooledObject()
    {
        for(int i = 0; i< pooledObject.Count; i++)
        {
            if (!pooledObject[i].activeInHierarchy)
            {
                return pooledObject[i];
            }
        }
        return null;
    }
}
