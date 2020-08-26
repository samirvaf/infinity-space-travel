using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    PlayerController player;

    Vector3 cameraInitialPosition;
    Vector3 playerPosition;

    private void Start()
    {
        cameraInitialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = player.transform.position;
        transform.position = cameraInitialPosition + playerPosition;
    }
}
