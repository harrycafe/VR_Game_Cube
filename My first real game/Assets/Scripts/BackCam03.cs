using UnityEngine;

public class BackCam03 : MonoBehaviour
{
    public float panSpeed=20f;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        pos.z -= panSpeed * Time.deltaTime;

        transform.position = pos;
    }
}
