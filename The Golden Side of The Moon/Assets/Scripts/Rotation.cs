using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButton(0)) {

            //Check if click was inside the torch's BoxCollider2D so that it can perform the next steps

            var position = Camera.main.WorldToScreenPoint(transform.position);
            var direction = Input.mousePosition - position;
            var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            if (angle > 90)
            {
                angle = 90;
            }
            if (angle < -90)
            {
                angle = -90;
            }
            var rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, Time.deltaTime * 180);
        }
	}
}
