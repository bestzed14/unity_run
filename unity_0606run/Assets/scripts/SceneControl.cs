using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>
    /// 場景控制:開始遊戲/結束遊戲
    /// </summary>

    private string sceneName;

    public void Quit()
    {
        Application.Quit();
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
    public void DelayLoadScene(string name)
    {
        sceneName = name;
        Invoke("LoadScene", 1.0f);
    }
    public void DelayQuit()
    {
        Invoke("Quit", 1.0f);
    }

    
    public void LoadSceneByObject(GameObject obj)
    {
        SceneManager.LoadScene(obj.name);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
