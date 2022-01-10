using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdPersonCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 offset;
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
