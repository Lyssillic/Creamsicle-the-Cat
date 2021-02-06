using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform PlayerTransform;
    private Vector3 offset;
    private float SmoothFactor = 0.1f;
    private float speed = 5.0f;

    void Start()
    {
        offset = transform.position - PlayerTransform.position;
    }

    void LateUpdate()
    {
        transform.LookAt(PlayerTransform);

        if (Input.GetMouseButton(0))
        {
            Quaternion angle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * speed, Vector3.up);
            offset = angle * offset;
        }

        Vector3 newPos = PlayerTransform.position + offset;
        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
    }
}