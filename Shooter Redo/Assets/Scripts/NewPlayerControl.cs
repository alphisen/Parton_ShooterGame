using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerControl : MonoBehaviour
{

    private AudioSource mAudioSrc;
    public bool MouseLook = true;
    public string HorzAxis = "Horizontal";
    public string VertAxis = "Vertical";
    public string FireAxis = "Fire1";
    public float MaxSpeed = 5f;
    public float ReloadDelay = 0.3f;
    public bool CanFire = true;
    public Transform[] TurretTransforms;

    private Rigidbody ThisBody = null;

    void Awake()
    {
        ThisBody = GetComponent<Rigidbody>();
    }

    void Start()
    {
         mAudioSrc = GetComponent<AudioSource>();

    }
       
    void Update()
    {
         if (Input.GetButtonDown(FireAxis) && CanFire)
            {
                    mAudioSrc.Play();
                    foreach (Transform T in TurretTransforms)
                    {
                        AmmoManager.SpawnAmmo(T.position, T.rotation);
                    }
                    CanFire = false;
                    Invoke("EnableFire", ReloadDelay);
            }
    }

    void EnableFire()
    {
        CanFire = true;
    }


}
