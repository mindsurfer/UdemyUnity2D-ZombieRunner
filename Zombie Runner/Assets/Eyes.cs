using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour 
{
  private Camera _eyes;
  private float _defaultFOV;

  // Use this for initialization
  void Start () 
  {
    _eyes = GetComponent<Camera>();
    _defaultFOV = _eyes.fieldOfView;
  }
  
  // Update is called once per frame
  void Update () 
  {
    if (Input.GetAxis("Zoom") == 1)
    {
      _eyes.fieldOfView = _defaultFOV / 1.5f;
    }
    else
    {
      _eyes.fieldOfView = _defaultFOV;
    }
  }
}
