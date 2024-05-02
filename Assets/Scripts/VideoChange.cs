using SojaExiles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;


public class VideoChange : MonoBehaviour
{
    VideoPlayer player;
    public GameObject videoMenu;
    public GameObject progressBar;
    public GameObject back;
    public GameObject blackScreen;
    public GameObject play;
    public GameObject pause;
    public TextMeshProUGUI currentMinutes;
    public TextMeshProUGUI totalMinutes;

    private void Awake()
    {
        player = GetComponent<VideoPlayer>();
    }
    private void Start()
    {
        string videoFileName = "opening.mp4";
        string videoPath = Application.streamingAssetsPath + "/" + videoFileName;
        player.Prepare();

        player.url = videoPath;
        player.Play();               //play opening screen video                                                  


    }

    private void Update()
    {
        if(player.isPlaying)
        {
            SetCurentTimeUI();       //find current video play time
        }
    }
    public void video1()             //play video 1 from streaming assets folder
    {
        string videoFileName = "video1.mp4";
        string videoPath = Application.streamingAssetsPath + "/" + videoFileName;
        player.url = videoPath;
        player.Play();
        totalMinutes.text = "/ 00:14";
        videoMenu.SetActive(false);
        progressBar.SetActive(true);
        blackScreen.SetActive(false);
        play.SetActive(false);
        pause.SetActive(true);
        back.SetActive(true);
        
    }
    public void video2()                 //play video 2 from streaming assets folder
    {
        string videoFileName = "video2.mp4";
        string videoPath = Application.streamingAssetsPath + "/" + videoFileName;
        player.url = videoPath;
        player.Play();
        totalMinutes.text = "/ 00:10";
        videoMenu.SetActive(false);
        progressBar.SetActive(true);
        blackScreen.SetActive(false);
        play.SetActive(false);
        pause.SetActive(true);
        back.SetActive(true);
    }
    public void video3()                //play video 3 from streaming assets folder
    {
        string videoFileName = "video3.mp4";
        string videoPath = Application.streamingAssetsPath + "/" + videoFileName;
        player.url = videoPath;
        player.Play();
        totalMinutes.text = "/ 00:34";
        videoMenu.SetActive(false);
        progressBar.SetActive(true);
        blackScreen.SetActive(false);
        play.SetActive(false);
        pause.SetActive(true);
        back.SetActive(true);
    }

    public void Back()                   //back btton fnctionality
    {
        player.Stop();
        videoMenu.SetActive(true);
        progressBar.SetActive(false);
        blackScreen.SetActive(true);
        back.SetActive(false);

    }

    void SetCurentTimeUI()              //current play time of the video
    {
        string minutes = Mathf.Floor((int)player.time / 60).ToString("00");     //converting player time to minutes and seconds
        string seconds = ((int)player.time % 60).ToString("00");
        currentMinutes.text = String.Format("{0} : {1} ", minutes, seconds);
    
    }
   
}
