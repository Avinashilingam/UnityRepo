using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneLoaderScript : MonoBehaviour
{
  public Button button;


    private void Start() 
    {
     button.onClick.AddListener(OnButtonClick);
    } 

    private void OnButtonClick()
    {
      Debug.Log("Button Clicked");
    }  
}

