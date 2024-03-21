using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // multiplayer's input ID
    public string inputID;
    
    // camera behind the player
    public GameObject cameraBehind;
    private Vector3 cameraBehindOffset;

    // camera into the player
    private GameObject cameraInto;

    // camera of all view
    public GameObject cameraAll;

    // camera container
    //GameObject[] cameras = new GameObject[10];
    List<GameObject> cameras = new List<GameObject>();

    // the key to switch camera
    public KeyCode cameraSwitchKey = KeyCode.F;

    //private Vector3 cameraIntoOffset;
    private float forwardSpeed = 20.0f;
    private float rotateSpedd = 100.0f;
    private float verticaInput;
    private float horizontalInput;


    // ObjectsSwitcher initial
    ObjectsSwitcher objectsSwitcher = new ObjectsSwitcher();

    // Start is called before the first frame update
    void Start()
    {
        cameraBehindOffset = new Vector3(0, 10, -14);

        cameraInto = this.transform.GetComponentInChildren<Camera>().gameObject;

        // put cameras into cameraContainer
        InitialCamera();
        
        
    }

    // initial cameras setting
    private void InitialCamera()
    {
        // The fist camera will be the default one, others will be closed
        cameras.Add(cameraBehind);
        cameras.Add(cameraInto);
        cameras.Add(cameraAll);
        objectsSwitcher.InitialObjectsSwitcher(cameras);
    }

    // Update is called once per frame
    void Update()
    {
        verticaInput = Input.GetAxis("Vertical" + inputID);
        horizontalInput = Input.GetAxis("Horizontal" + inputID);

        // move the car forward based on the vertical
        this.transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed * verticaInput);
        
        // move the car slide based on the horizontal
        //this.transform.Translate(Vector3.right * Time.deltaTime * rotateSpedd * horizontalInput);

        // move the car rotate based on the horizontal
        this.transform.Rotate(Vector3.up, Time.deltaTime * rotateSpedd * horizontalInput);

        // press key 'F' change the view of the player
        
        //Debug.Log(cameraInto.transform.position);

        if (Input.GetKeyDown(cameraSwitchKey))
        {

            objectsSwitcher.SwitchObjects();
           
            
        }

    }

    private void LateUpdate()
    {

        cameraBehind.transform.position = this.transform.position + cameraBehindOffset;

        
    }

}
