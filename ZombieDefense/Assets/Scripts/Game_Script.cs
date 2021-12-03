using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Script : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject player;
    public GameObject zombiePrefab;

    private float beginWave = 5f;
    private float waveLevel = 1;

    private bool gameStart = false;

    // Start is called before the first frame update
    void Start()
    {
        var camAnim = mainCam.GetComponent<Animator>();
        camAnim.Play("Camera_Down");
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStart) {
            beginWave -= Time.deltaTime;
            if (beginWave < 0) {
                print("Game Begin");
                createWave(waveLevel);
                gameStart = true;
            }
        }
    }

    public void createWave(float waveLevel) {
        for (int i = 0; i <= (5 * waveLevel); i++) {
            var spawnPoint = Random.Range(1, 5);
            switch(spawnPoint) {
                case 1:
                    Instantiate(zombiePrefab, new Vector3(Random.Range(-5, 5), 1.5f, Random.Range(25, 35)), Quaternion.identity);
                    break;

                case 2:
                    Instantiate(zombiePrefab, new Vector3(Random.Range(25, 35), 1.5f, Random.Range(-5, 5)), Quaternion.identity);
                    break;

                case 3:
                    Instantiate(zombiePrefab, new Vector3(Random.Range(-5, 5), 1.5f, Random.Range(-25, -35)), Quaternion.identity);
                    break;

                case 4:
                    Instantiate(zombiePrefab, new Vector3(Random.Range(-25, -35), 1.5f, Random.Range(-5, 5)), Quaternion.identity);
                    break;

                default:
                    print("Broke for some reason");
                    break;
            }
        }
    }
}
