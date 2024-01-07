using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// #if UNITY_EDITOR

// using UnityEditor;

// #endif

public class lean_template : MonoBehaviour
{
    public enum UIAnimtationType
    {
        moveGUI,
        rotateX,
        rotateY,
        moveX,
        moveY,
        scaleGUI,
        fade,
        moveGUIbyTarget,
        destroy
    }

    // #region Editor
    // #if UNITY_EDITOR

    // [CustomEditor(typeof(lean_template))]
    // public class lean_templateEditor : Editor
    // {
    //     // public override void OnInspectorGUI()
    //     // {
    //     //     base.OnInspectorGUI();

    //     //     lean_template lean_Template = (lean_template)target;

    //     //     EditorGUILayout.Space();
    //     //     EditorGUILayout.LabelField("Details");
    //     //     EditorGUILayout.BeginVertical();
            

    //     //     EditorGUILayout.EndVertical();
    //     // }

    // }

    // #endif

    // #endregion
    [Tooltip("Objek yg Digerakin")]
    public GameObject AnimatedObject;
      [Tooltip("jenis ease behavior")]
    public LeanTweenType easeType;
      [Tooltip("jenis animasi")]
    public UIAnimtationType type;
      [Tooltip("semua")]
    public float duration;
      [Tooltip("optional untuk semua")]
    public float delay;
      [Tooltip("scale")]
    public Vector2 scale;
      [Tooltip("blm kepake")]
    public float Position;
      [Tooltip("moveX moveY RotateX rotateY")]
    public float moveto;
      [Tooltip("MoveGUI")]
    public Vector2 pos;
      [Tooltip("fade")]
    public CanvasGroup canvasGroup;
      [Tooltip("moveGUIbyTarget")]
    public Transform targetPos;

    public GameObject btndestroy;

    void Start()
    {
        if (AnimatedObject == null)
        {
            AnimatedObject = gameObject;
            
        }
        switch (type)
        {
            case UIAnimtationType.moveX:
                moveX();
                break;
            case UIAnimtationType.moveY:
                moveY();
                break;
            case UIAnimtationType.scaleGUI:
                scaleGUI();
                break;
            case UIAnimtationType.fade:
                fade();
                break;
            case UIAnimtationType.rotateX:
                rotateX();
                break;
            case UIAnimtationType.rotateY:
                rotateY();
                break;
            case UIAnimtationType.moveGUI:
                moveGUI();
                break;
            case UIAnimtationType.moveGUIbyTarget:
                moveGUIbyTarget();
                break;
            case UIAnimtationType.destroy:
                destroy();
                break;
            
        }

    }

    // void move()
    // {
    //     // LeanTween.move(AnimatedObject,Position,duration).setEase(easeType);
    // }
    void scaleGUI() //legit
    {
        // LTRect bRect = new LTRect( 0f, 0f, 100f, 50f );
        LeanTween.scale( AnimatedObject,scale,duration).setEase(easeType);

    }

    void fade()
    {
        // LeanTween.alpha(AnimatedObject,1f,duration).setEase(easeType);

        // LeanTween.alphaCanvas(canvasGroup,1f,1f);
    }

    void moveX()
    {
        LeanTween.moveX(AnimatedObject,moveto,duration).setEase(easeType).setDelay(delay);
    }

    void moveY()
    {
        LeanTween.moveY(AnimatedObject,moveto,duration).setEase(easeType).setDelay(delay);
    }

    void rotateX()
    {
        LeanTween.rotateX(AnimatedObject,moveto,duration).setEase(easeType).setDelay(delay);
    }

    void rotateY()
    {
        LeanTween.rotateY(AnimatedObject,moveto,duration).setEase(easeType).setDelay(delay);
        
    }

    void moveGUI()
    {
        LeanTween.move(AnimatedObject,pos,duration).setEase(easeType).setDelay(delay);
    }
     void moveGUIbyTarget()
    {
        LeanTween.move(AnimatedObject,targetPos,duration).setEase(easeType).setDelay(delay);
    }

    public void destroy()
    {
      Destroy(gameObject);
    }

    
}
