using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inbetween_script : MonoBehaviour
{
    public enum TweenType {scale,popup}

    public TweenType tweenType; 
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        if (panel == null )
        {
            panel = gameObject;
        }
        switch (tweenType)
        {
            case TweenType.scale:
                scale();
                break;
            case TweenType.popup:
                popup();
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void scale()
    {
        LeanTween.scaleX(panel,1f,1f);
        LeanTween.scaleY(panel,1f,1f);
    }

    public void unscale()
    {
        LeanTween.scaleX(panel,0f,1f);
        LeanTween.scaleY(panel,0f,1f);

    }

    public void popup()
    {
        LeanTween.moveLocalY(panel,5,1);

    }
    public void popdown()
    {
        LeanTween.moveLocalY(panel,-5,1);
    }
}
