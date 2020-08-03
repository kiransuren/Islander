using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public Transform camera;
    public Vector3 offset;
    public Vector3 rotateX;
    public Vector3 rotateY;
    public Ray lookRay;

    public float mouseSensitivity;
    



    void FixedUpdate()
    {
        Cursor.lockState = CursorLockMode.Locked;
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        float rotAmountX = mouseX * mouseSensitivity;
        float rotAmountY = mouseY * mouseSensitivity;


        Vector3 cameraRot = camera.transform.rotation.eulerAngles;
        cameraRot.x -= rotAmountY;
        cameraRot.y += rotAmountX;
        cameraRot.z = 0;

        if(cameraRot.x > 270 | cameraRot.x < 90)
        {
            camera.rotation = Quaternion.Euler(cameraRot);
        }

        lookRay = new Ray(camera.position, camera.forward);
        camera.position = player.position + offset;
    }

}
