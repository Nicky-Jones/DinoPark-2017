using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentInstance : Agent
{
    AStarSearch aStar;
    ASPathFollower pathFoll;
    private Vector3 directionVector;

    // Use this for initialization
    void Start () {
        aStar = gameObject.GetComponent<AStarSearch>();
        pathFoll = gameObject.GetComponent<ASPathFollower>();
	}
	
	// Update is called once per frame
	new void Update () {
        if (pathFoll.path.nodes.Count < 1 || pathFoll.path == null)
            pathFoll.path = aStar.path;

        directionVector = pathFoll.getDirectionVector();

        base.Update();
	}
}
