using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cobatwee : MonoBehaviour
{
    public enum Style {move, scale , rotate}
    public LeanTweenType easetype;
    public GameObject obyek;
    public float duration;
    public float delay;

    public int moveto;

    public Vector2 kordinat;


    public void Scale()
    {
        LeanTween.scaleX(obyek,moveto,duration).setEase(easetype).setDelay(delay);
        LeanTween.scaleY(obyek,moveto,duration).setEase(easetype).setDelay(delay);
    }

    public void Move()
    {
        LeanTween.move(obyek,kordinat,duration).setEase(easetype).setDelay(delay);

    }

    public void rotate()
    {

        LeanTween.rotate(obyek,kordinat,duration).setEase(easetype).setDelay(delay);

    }

    public void OnClickButton()
    {

    }
}

