using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Tooltip("The target object to follow.")]
    public Transform target;

    [Tooltip("The speed at which the camera follows the target.")]
    public float followSpeed = 5f;

    [Tooltip("The offset from the target object.")]
    public Vector3 offset = new Vector3(0f, 5f, -10f);

    private void LateUpdate()
    {
        if (target == null)
        {
            return;
        }

        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
    }
}