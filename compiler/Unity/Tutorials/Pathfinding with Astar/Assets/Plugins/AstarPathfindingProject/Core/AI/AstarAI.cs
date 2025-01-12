using UnityEngine;
using System.Collections;
using Pathfinding;
using System.Diagnostics;

public class AstarAI : MonoBehaviour
{
  public Vector3 targetPosition;
  private Seeker seeker;
  private CharacterController controller;
  //The calculated path
  public Path path;
  //The AI's speed per second
  public float speed = 100;
  //The max distance from the AI to a waypoint for it to continue to the next waypoint
  public float nextWaypointDistance = 3;
  //The waypoint we are currently moving towards
  private int currentWaypoint = 0;

  public void Start()
  {
    Seeker seeker = GetComponent<Seeker>();
    controller = GetComponent<CharacterController>();
    //Start a new path to the targetPosition, return the result to the OnPathComplete function
    seeker.StartPath(transform.position, targetPosition, OnPathComplete);
  }
  public void OnPathComplete(Path p)
  {
    UnityEngine.Debug.Log("Yay, we got a path back. Did it have an error? " + p.error);
    if (!p.error)
    {
      path = p;
      //Reset the waypoint counter
      currentWaypoint = 0;
    }
  }
  public void Update()
  {
    if (path == null)
    {
      //We have no path to move after yet
      return;
    }
    if (currentWaypoint >= path.vectorPath.Count)
    {
      UnityEngine.Debug.Log("End Of Path Reached");
      return;
    }
    //Direction to the next waypoint
    Vector3 dir = (path.vectorPath[currentWaypoint] - transform.position).normalized;
    dir *= speed * Time.deltaTime;
    controller.SimpleMove(dir);
    //Check if we are close enough to the next waypoint
    //If we are, proceed to follow the next waypoint
    if (Vector3.Distance(transform.position, path.vectorPath[currentWaypoint]) < nextWaypointDistance)
    {
      currentWaypoint++;
      return;
    }
  }

}

