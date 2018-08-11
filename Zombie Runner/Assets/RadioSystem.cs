using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystem : MonoBehaviour 
{
  public AudioClip MakeInitialCall;
  public AudioClip InitialCallReply;

  private AudioSource _audioSource;

  // Use this for initialization
  void Start () 
  {
    _audioSource = GetComponent<AudioSource>();
  }
  
  // Update is called once per frame
  void Update () 
  {
    
  }

  void OnMakeInitialHeliCall()
  {
    _audioSource.clip = MakeInitialCall;
    _audioSource.Play();

    Invoke("DispatchHelicopter", MakeInitialCall.length);
  }

  void DispatchHelicopter()
  {
    _audioSource.clip = InitialCallReply;
    _audioSource.Play();

    BroadcastMessage("OnDispatchHelicopter");
  }
}
