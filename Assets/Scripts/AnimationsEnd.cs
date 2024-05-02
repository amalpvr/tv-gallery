using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationsEnd : MonoBehaviour
{
    public GameObject Buttons;
    public GameObject ProgressBar;

    private void Awake()
    {
      Buttons.SetActive(false);
      ProgressBar.SetActive(false);
    }
    public void OnAnimationEnd()
    {
        Buttons.SetActive(true);                //enable gallery when initial animation ends
       

    }

}
