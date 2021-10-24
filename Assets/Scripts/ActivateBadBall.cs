using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBadBall : MonoBehaviour
{

    public string player = "Player";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag(player))
        {
            Debug.Log("Activate BadBall");
            GameObject badBall = GameObject.Find("BadBall");
            GameObject alarm = GameObject.Find("Alarm");
            GameObject hover = GameObject.Find("Hover");

            FollowPlayer fp = badBall.gameObject.GetComponent<FollowPlayer>();
            AudioSource audioAlarm = alarm.GetComponent<AudioSource>();
            AudioSource audioHover = hover.GetComponent<AudioSource>();

            audioAlarm.Play();
            audioHover.Play();

            fp.enabled = true;
        }        
    }
}
