using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1turret_sc : MonoBehaviour
{

    [SerializeField]
    private AudioSource turret_sound;
    
    public static p1turret_sc Instance;

    void Start()
    {
        if(Instance == null)
            Instance = this;

        if (PlayerPrefs.GetInt("Continue") == 1)
        {
            LoadData();
        }
    }

    // Update is called once per frame
    float turretSpeed = 0.1f;
    void Update()
    {
        // Get the mouse delta. This is not in the range -1...1
        float h = turretSpeed * Input.GetAxis("Turret1")*Time.timeScale;
        //Debug.Log(h);
        turretRotation(h);
        turretSound(h);
    }

    private void LoadData()
    {
        if (PlayerPrefs.HasKey("P1TurretX"))
        {
            transform.eulerAngles = new Vector3(PlayerPrefs.GetFloat("P1TurretX"), PlayerPrefs.GetFloat("P1TurretY"), PlayerPrefs.GetFloat("P1TurretZ"));
        }
    }

    void turretRotation(float horizontalInput)
    {
        transform.Rotate(0, 0, horizontalInput);
    }
    void turretSound(float horizontalInput)
    {

        if (horizontalInput != 0)
        {
            if (!turret_sound.isPlaying)
            {
                turret_sound.volume = 0.5f;
                turret_sound.Play();
            }
        }
        else
        {
            if (turret_sound.isPlaying && turret_sound.volume > 0.1)
            {
                turret_sound.volume -= turret_sound.volume * Time.deltaTime * 5f;
            }

            else if (turret_sound.volume < 0.1)
            {
                turret_sound.Stop();
            }
        }
    }
}
