using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeUpBadBall : MonoBehaviour
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
            Debug.Log("Wake up BadBall");
            GameObject badBall = GameObject.Find("BadBall");

            AudioSource audio = badBall.gameObject.GetComponent<AudioSource>();

            audio.Play();

        }        
    }
}
