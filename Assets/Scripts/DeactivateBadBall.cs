using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateBadBall : MonoBehaviour
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
            Debug.Log("Deactivate BadBall");
            GameObject badBall = GameObject.Find("BadBall");
            GameObject deactivateSound = GameObject.Find("DeactivateSound");
            GameObject hover = GameObject.Find("Hover");

            FollowPlayer fp = badBall.gameObject.GetComponent<FollowPlayer>();
           
            AudioSource audio = deactivateSound.GetComponent<AudioSource>();
            AudioSource audioHover = hover.GetComponent<AudioSource>();

            audio.Play();
            audioHover.Stop();

            fp.enabled = false;
        }        
    }
}
