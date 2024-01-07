using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanagement : MonoBehaviour
{
   
    // Update is called once per frame
    public void LoadToSecene(string sceneName)
    {
        
        SceneManager.LoadScene(sceneName);
    }
}
