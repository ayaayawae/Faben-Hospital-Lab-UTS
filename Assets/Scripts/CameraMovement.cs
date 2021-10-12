using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] 
    private GameObject MyCamera;
    private Light PointLight1;
    private float MoveSens = 0.05f;
    private float CamSens = 3.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        MyCamera = GameObject.FindWithTag("MainCamera");
        PointLight1 = GameObject.FindWithTag("PointLight1").GetComponent<Light>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // move with keyboard
        this.KeyboardMovement();

        // look with mouse
        this.LookRotation();  

        // object detection with crosshair
        this.RayCast();
    }

    public void LookRotation()     
    {    
        yaw += CamSens * Input.GetAxis("Mouse X");
        pitch -= CamSens * Input.GetAxis("Mouse Y");

        pitch = Mathf.Clamp(pitch, -90f, 90f);

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    } 

    public void KeyboardMovement() {
        if (Input.GetKey(KeyCode.W)) {
            MyCamera.transform.Translate(Vector3.forward * MoveSens);
        }
        if (Input.GetKey(KeyCode.A)) {
            MyCamera.transform.Translate(Vector3.left * MoveSens);
        }
        if (Input.GetKey(KeyCode.S)) {
            MyCamera.transform.Translate(Vector3.back * MoveSens);
        }
        if (Input.GetKey(KeyCode.D)) {
            MyCamera.transform.Translate(Vector3.right * MoveSens);
        }
    }

    public void RayCast() {
        if(Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 2.0f) && hit.transform.tag == "buttonPL1") {
                if(PointLight1.enabled == true) {
                    PointLight1.enabled = false;
                } else {
                    PointLight1.enabled = true;
                }
                Debug.Log("asd");
            }
        } 
    }
}
