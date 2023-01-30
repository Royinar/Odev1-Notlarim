using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFootSound : MonoBehaviour
{
    private const double V = 0.8;
    public AudioSource footStepsSound;
    public float sprintSoundwalk;
    public int sprintSoundrun;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        sprintSoundwalk = (float)V;
        sprintSoundrun = 1;
        if (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.S) || (Input.GetKey(KeyCode.D)))))
        {
            footStepsSound.enabled = true;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                //footStepsSound.enabled = false;
                //sprintSound.enabled = true;
                footStepsSound.pitch = sprintSoundrun;
            }
            else
            {
                footStepsSound.pitch = sprintSoundwalk;
                //sprintSound.enabled = false;
            }
        }
        else
        {
            footStepsSound.enabled = false;
            //sprintSound.enabled = false;
            //footStepsSound.pitch = 0.8;
        }
    }
}
