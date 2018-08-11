using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{
  public Transform SpawnPoints;
  public GameObject LandingArea;

  private Transform[] _spawnPoints;
  private ClearArea _clearArea;
  private bool SpawnAgain;

  // Use this for initialization
  void Start()
  {
    _spawnPoints = SpawnPoints.GetComponentsInChildren<Transform>();
    _clearArea = GetComponent<ClearArea>();
    SpawnAgain = true;
  }

  // Update is called once per frame
  void Update()
  {
    //if (SpawnAgain)
    //  Respawn();
  }

  void OnFindClearArea()
  {
    Invoke("DropFlare", 3f);
  }

  void DropFlare()
  {
    // Drop a flare
    Instantiate(LandingArea, transform.position, transform.rotation);
  }

  private void Respawn()
  {
    var randomLocation = _spawnPoints[Random.Range(1, _spawnPoints.Length)];
    transform.position = randomLocation.position;
    SpawnAgain = false;
  }
}
