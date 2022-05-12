using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabManager : MonoBehaviour
{
    // Start is called before the first frame update
    #region SINGLETON REGION
    private static PrefabManager instance;
    public static PrefabManager Instance
    {
        get
        {
            if (instance == null)
            {

                instance = GameObject.FindObjectOfType<PrefabManager>();
                if (instance == null)
                {
                    GameObject container = new GameObject("PrefabManager");
                    instance = container.AddComponent<PrefabManager>();
                }
            }

            return instance;
        }
    }
    #endregion
    #region PUBLIC VARIABLES
    // An array of large asteroid prefabs. Order doesn't matter.
    public GameObject[] largeAsteroidPrefabs;

    // An array of small asteroid prefabs. Order doesn't matter.
    public GameObject[] smallAsteroidPrefabs;
    #endregion

    #region MONOBEHAVIOUR METHODS
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
    #region PUBLIC METHODS
    // Return a large asteroid prefab.
    public GameObject GetLargeAsteroidPrefab()
    {
        if (largeAsteroidPrefabs.Length > 0)
            return largeAsteroidPrefabs[Random.Range(0, largeAsteroidPrefabs.Length)];

        return null;
    }

    // Return a small asteroid prefab.
    public GameObject GetSmallAsteroidPrefab()
    {
        if (smallAsteroidPrefabs.Length > 0)
            return smallAsteroidPrefabs[Random.Range(0, smallAsteroidPrefabs.Length)];

        return null;
    }
    #endregion
}
