using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour 
{
  private Rigidbody _rigidBody;
  private bool _heliCalled;

  // Use this for initialization
  void Start () 
  {
    _rigidBody = GetComponent<Rigidbody>();
  }
  
  // Update is called once per frame
  void Update () 
  {
    //if (Input.GetAxis("CallHeli") == 1 && !_heliCalled)
    //{
    //  _heliCalled = true;
    //  _audioSource.Play();
    //}
  }

  void OnDispatchHelicopter()
  {
    _rigidBody.velocity = new Vector3(0f, 0f, 50f);
    _heliCalled = true;
  }
}
