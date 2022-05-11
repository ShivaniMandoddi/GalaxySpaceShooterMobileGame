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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
