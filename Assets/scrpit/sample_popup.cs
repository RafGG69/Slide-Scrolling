using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sample_popup : MonoBehaviour
{
  public GameObject popupPrefab;

  public Transform canvasParent;

  public Transform targetPos;

  public void OpenPopup() 
  {
    GameObject popup =  Instantiate(popupPrefab,canvasParent);

    if (targetPos == null) return;
  
    popup.GetComponent<lean_template>().targetPos = targetPos;
  }



}
