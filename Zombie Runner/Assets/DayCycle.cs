using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCycle : MonoBehaviour 
{
  public float MinutesPerSecond;

  // Use this for initialization
  void Start () 
  {
  }
  
  // Update is called once per frame
  void Update () 
  {
    //var angleThisFrame = Time.deltaTime / 360 * TimeScale;
    //transform.RotateAround(transform.position, Vector3.forward, angleThisFrame);
    var angleThisFrame = MinutesPerSecond * Time.deltaTime * 360 / 1440;
    transform.Rotate(angleThisFrame, 0, 0, Space.Self);
  }
}
