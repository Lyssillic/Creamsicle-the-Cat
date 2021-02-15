using UnityEngine;

public class Rotation : MonoBehaviour {
    public Vector3 rotationAngle = new Vector3(0, 0, 10);
    public float rotationSpeed = 15;

	void Update () {
        transform.Rotate(rotationAngle * rotationSpeed * Time.deltaTime);
	}
}
