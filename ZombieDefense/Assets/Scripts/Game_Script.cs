using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Script : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject player;
    
    private float beginWave = 5f;

    private bool waveStart = false;

    // Start is called before the first frame update
    void Start()
    {
        var camAnim = mainCam.GetComponent<Animator>();
        camAnim.Play("Camera_Down");
    }

    // Update is called once per frame
    void Update()
    {
        if (!waveStart) {
            beginWave -= Time.deltaTime;
            if (beginWave < 0) {
                waveStart = true;
            }
        }
        if (waveStart == true) {
            mainCam.transform.SetParent(player.transform);
        }

    }
}
