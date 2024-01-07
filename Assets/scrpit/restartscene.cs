using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
