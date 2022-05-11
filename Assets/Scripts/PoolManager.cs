using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    // Start is called before the first frame update
    #region SINGLETON REGION
    private static PoolManager instance;
    public static PoolManager Instance
    {
        get
        {
            if (instance == null)
            {

                instance = GameObject.FindObjectOfType<PoolManager>();
                if (instance == null)
                {
                    GameObject container = new GameObject("PoolManager");
                    instance = container.AddComponent<PoolManager>();
                }
            }

            return instance;
        }
    }
    #endregion
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
