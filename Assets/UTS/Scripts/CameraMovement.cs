using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] 
    private GameObject MyCamera;
    private GameObject AudioCue;
    private Light PointLight1, PointLight2, PointLight3;
    private float MoveSens = 0.05f;
    private float CamSens = 3.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    public Camera camera;
    public AudioSource audioSource;

    private bool disco = false;

    // Start is called before the first frame update
    void Start()
    {
        MyCamera = GameObject.FindWithTag("MainCamera");
        PointLight1 = GameObject.FindWithTag("PointLight1").GetComponent<Light>();
        PointLight2 = GameObject.FindWithTag("PointLight2").GetComponent<Light>();
        PointLight3 = GameObject.FindWithTag("PointLight3").GetComponent<Light>();
        AudioCue = GameObject.FindWithTag("AudioCue");
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

        //sprint
        this.Sprint();

        //back to main menu
        this.goToMainMenu();

        if(!disco )
        {
            StartCoroutine( HandleDisco() );
            PointLight1.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }
    }

    private IEnumerator HandleDisco()
    {
        disco = true;
        // process pre-yield
        yield return new WaitForSeconds( 0.5f );
        // process post-yield
        disco = false;
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
            if (Physics.Raycast(ray, out hit, 5.0f) && hit.transform.tag == "buttonPL1") {
                if(PointLight1.enabled == true) {
                    PointLight1.enabled = false;
                    Debug.Log("Lights Off");
                } else {

                    PointLight1.enabled = true;
                    Debug.Log("Lights On");

                }
            }
            if (Physics.Raycast(ray, out hit, 5.0f) && hit.transform.tag == "buttonPL2") {
                if(PointLight2.enabled == true) {
                    PointLight2.enabled = false;
                    Debug.Log("Lights Off");
                } else {
                    PointLight2.enabled = true;
                    Debug.Log("Lights On");
                }
            }
            if (Physics.Raycast(ray, out hit, 5.0f) && hit.transform.tag == "buttonPL3") {
                if(PointLight3.enabled == true) {
                    PointLight3.enabled = false;
                    Debug.Log("Lights Off");
                } else {
                    PointLight3.enabled = true;
                    Debug.Log("Lights On");

                }
            }
            if (Physics.Raycast(ray, out hit, 5.0f) && hit.transform.tag == "AudioCue") {
                if(audioSource.isPlaying == false){
                    audioSource.Play();
                    Debug.Log("Audio Played"); 
                } else{
                    audioSource.Pause();
                    Debug.Log("Audio Paused"); 
                }   
            }
        } 
    }

    public void Sprint() {
        if(Input.GetKey(KeyCode.LeftShift)) {
            MoveSens = 0.5f;
        } else {
            MoveSens = 0.05f;
        }
    }

    public void goToMainMenu() {
        if(Input.GetKey(KeyCode.Escape) && Input.GetKey(KeyCode.Space)) {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("MainMenu");
        }
    }
}