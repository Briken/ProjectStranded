using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {

    Vector3 fleePoint;

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        Touch moveTouch = Input.GetTouch(0);

        Debug.Log("Stop touching meeeee!");

        fleePoint = moveTouch.position;
    }

    void MoveFromTouch(Vector3 targetPoint, Vector3 velocity)
    {

    }

}
