using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    private void Start(){
        videoPlayer = GetComponent<VideoPlayer>();
    }

    public void Play(){
        videoPlayer.Play();
    }

    public void Pause(){
        videoPlayer.Pause();
    }

    //Take us back to the starting point of the video. 
    public void Stop(){
        videoPlayer.Stop();
    }

    //load url adress the video file.
    public void  URLToVideo(string url){
        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = url;
        videoPlayer.Prepare();  //Load the video
        videoPlayer.prepareCompleted += VideoPlayer_prepareCompleted;   //Play the video. 
    }

    private void VideoPlayer_prepareCompleted(VideoPlayer source){
        Play();
    }
}
