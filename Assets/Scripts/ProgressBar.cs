using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.Video;

public class ProgressBar : MonoBehaviour , IDragHandler , IPointerDownHandler
{
    public VideoPlayer player;
    Image progress;

    private void Awake()
    {
        progress = GetComponent<Image>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player.frameCount > 0)
            progress.fillAmount = (float)player.frame / (float)player.frameCount;  //fill amount of the video player scrub area
        
    }

    

    private void TrySkip(PointerEventData eventData)
    {
        Vector2 localPoint;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(progress.rectTransform, eventData.position, null, out localPoint))
        {
            float pct = Mathf.InverseLerp(progress.rectTransform.rect.xMin,progress.rectTransform.rect.xMax, localPoint.x); //finding the current pointer down position data and converting to local position
            SkipToPercent(pct);    //converting it into a value b/w 0 and 1
        }                      

    }

    private void SkipToPercent(float pct)
    {
        var frame = player.frameCount * pct;   
        player.frame = (long)frame;                 //converting pct to video frame and passing it to player
    }

    public void OnDrag(PointerEventData eventData)
    {
        TrySkip(eventData);                                //onDrag callback
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        TrySkip(eventData);                                //on pointer down callback
    }

   
}
