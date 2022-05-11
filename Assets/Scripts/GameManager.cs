using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    #region SINGLETON REGION
    private static GameManager instance;
    public static GameManager Instance
    { 
        get 
        {
            if(instance==null)
            {

                instance = GameObject.FindObjectOfType<GameManager>();
                if(instance==null)
                {
                    GameObject container = new GameObject("GameManager");
                    instance = container.AddComponent<GameManager>();
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
