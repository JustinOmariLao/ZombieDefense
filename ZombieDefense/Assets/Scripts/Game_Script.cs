using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Script : MonoBehaviour
{
    public Animator cameraAnimator;
    
    // Start is called before the first frame update
    void Start()
    {
        cameraAnimator.Play("Camera_Down");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
