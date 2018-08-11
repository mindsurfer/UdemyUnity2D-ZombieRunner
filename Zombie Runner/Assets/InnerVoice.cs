using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerVoice : MonoBehaviour 
{
  public AudioClip WhatHappened;
  public AudioClip GoodLandingArea;

  private AudioSource _audioSource;

  // Use this for initialization
  void Start () 
  {
    _audioSource = GetComponent<AudioSource>();
    _audioSource.clip = WhatHappened;
    _audioSource.Play();
  }

  void OnFindClearArea()
  {
    print(name + " OnFindClearArea");
    _audioSource.clip = GoodLandingArea;
    _audioSource.Play();

    Invoke("CallHeli", GoodLandingArea.length + 1f);
  }

  void CallHeli()
  {
    SendMessageUpwards("OnMakeInitialHeliCall");
  }
}
