using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchEnemy : MonoBehaviour {

    public AudioClip hit;
    // Use this for initialization
    void Start () {
        GetComponent<AudioSource>().clip = hit;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began)) 
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                if (raycastHit.collider.tag == "Enemy")
                {
                    Score.score += 1;
                    Handheld.Vibrate();
                    Destroy(raycastHit.transform.gameObject);
                    GetComponent<AudioSource>().Play();
                }
            }
        }
    }
}
