using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMgr : MonoBehaviour
{
    public static SoundMgr instance;
    public AudioClip jumpSfx;
    public AudioClip slideSfx;
    public AudioClip tokenSfx;
    public AudioClip gameOversfx;

    private AudioSource asource;

    public void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);

        // create the audiosource if we need it
        if (asource == null)
        {
            asource = this.gameObject.AddComponent<AudioSource>();
            if (asource)
            {
                asource.playOnAwake = false;
            }
        }
    }

    //method for sliding/rolling sound effect
    public void SlideSound()
    {
        if (asource != null)
        {
            if (slideSfx != null)
                asource.PlayOneShot(slideSfx);
        }
    }
    //method for collecting coins sound effect
    public void TokenSound()
    {
        if (asource != null)
        {
            if (tokenSfx != null)
                asource.PlayOneShot(tokenSfx);
        }
    }
    //method for jumping sound effect
    public void JumpSound()
    {
        if (asource != null)
        {
            if (jumpSfx != null)
                asource.PlayOneShot(jumpSfx);
        }
    }
    //method for losing sound effect
    public void GameOver()
    {
        if (asource != null)
        {
            if (gameOversfx != null)
                asource.PlayOneShot(gameOversfx);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
