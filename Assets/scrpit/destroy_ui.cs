using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_ui : MonoBehaviour
{
    public GameObject obyek;

    public LeanTweenType setease;

    public float duration;
    public float Delay;

    public void destroy()
    {
        Destroy(obyek);
    }

    public void scaledestroy()
    {

        LeanTween.scaleX(obyek,0,duration).setEase(setease).setDelay(Delay);
        LeanTween.scaleY(obyek,0,duration).setEase(setease).setDelay(Delay);

        Destroy(obyek,duration);

        
        
    }
}
