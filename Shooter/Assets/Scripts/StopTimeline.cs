using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class StopTimeline : MonoBehaviour
{
    [SerializeField] PlayableDirector director;
    [SerializeField] AudioSource click;

    private void Awake()
    {
    director.GetComponent<PlayableDirector>();
    }
    public void StartTimeline()
    {
    director.time = director.time;
    director.playableGraph.GetRootPlayable(0).SetSpeed(1);
    click.Play();
    }
    public void StopDirector()
    {
    director.playableGraph.GetRootPlayable(0).SetSpeed(0);
    }

}
