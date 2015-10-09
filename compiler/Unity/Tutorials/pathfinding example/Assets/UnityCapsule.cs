using UnityEngine;
using System.Collections;

public class UnityCapsule : MonoBehaviour {
  public Transform goal;
  public NavMeshAgent agent;
  // Use this for initialization
  void Start () {
    goal = GameObject.FindWithTag("target").GetComponent<Transform>();
    agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
    agent.destination = goal.position;
    goal.position += new Vector3(Input.GetAxis("Horizontal") * 0.2f,0.0f, Input.GetAxis("Vertical") * 0.2f);
	}
}
                   