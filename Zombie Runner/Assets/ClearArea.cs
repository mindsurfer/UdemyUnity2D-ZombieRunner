using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour
{
  private BoxCollider _boxCollider;
  public float _timeSinceLastCollision;
  private bool _safeToLand;

  // Use this for initialization
  void Start()
  {
    _boxCollider = GetComponent<BoxCollider>();
  }

  // Update is called once per frame
  void Update()
  {
    CheckSafeLandingArea();
  }

  void OnTriggerStay(Collider collider)
  {
    if (collider.tag != "Player")
      _timeSinceLastCollision = 0f;
  }

  public bool IsSafeToLand()
  {
    return _safeToLand;
  }

  public void ResetTimer()
  {
    _timeSinceLastCollision = Time.time + 10f;
  }

  private void CheckSafeLandingArea()
  {
    //if (_safeToLand)
    //  return;

    _timeSinceLastCollision += Time.deltaTime;

    if (_timeSinceLastCollision > 1f && Time.realtimeSinceStartup > 10f && !_safeToLand)
    {
      _safeToLand = true;
      print("SendMessageUpwards(OnFindClearArea)");
      SendMessageUpwards("OnFindClearArea");
    }
  }
}
