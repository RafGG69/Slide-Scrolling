using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] public GameObject target;

    [SerializeField] public Vector2 Finalscale;

    [SerializeField] public Vector2 Currentscale;


    public LeanTweenType type;

    public float duration;

    public float moveto;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void scalebutton()
    {
        // LeanTween.scale(target, scale, duration).setEase(type).setOnComplete(() =>
        // {
        //     LeanTween.scale(target, scale, duration).setEase(type).setOnComplete(() =>
        //     {
        //         LeanTween.scale(target, scale, duration).setEase(type).setOnComplete(() =>
        //         {
        //             LeanTween.scale(target, scale, duration).setEase(type).setOnComplete(() =>
        //             {
        //                 LeanTween.scale(target, scale, duration);
        //             });
        //         });
        //         {

        //         }
        //     });


        // });

        // LeanTween.scale(target, Vector2.one * 2f, duration).setEase(type);

        LeanTween.scale(target, Finalscale, duration).setEase(type);


    }

    public void unscale()
    {
        LeanTween.scale(target, Currentscale, duration).setEase(type);


    }
}


