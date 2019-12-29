using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 camPosInitial;
    // Start is called before the first frame update
    void Start()
    {
        camPosInitial = transform.position;
    }
    private void LateUpdate()
    {
        transform.position = player.transform.position + camPosInitial;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
