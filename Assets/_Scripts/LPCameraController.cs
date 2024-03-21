using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LPCameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = new Vector3(0,10,-14);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = player.transform.position + cameraOffset;
    }
}
