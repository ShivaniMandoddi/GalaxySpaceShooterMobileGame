using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public GameObject homePanel;
    public GameObject aboutPanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void BackToHome()
    {
        homePanel.SetActive(true);
        aboutPanel.SetActive(false);
    }
    public void About()
    {
        aboutPanel.SetActive(true);
        homePanel.SetActive(false);
        
    }
}
