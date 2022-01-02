using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audios2 : MonoBehaviour
{
    public GameObject BackgroundMusic;
    AudioSource backmusic;
    int a = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (a == 1)
        {
            Destroy(BackgroundMusic);
        }
        backmusic = BackgroundMusic.GetComponent<AudioSource>();
        DontDestroyOnLoad(BackgroundMusic);
        a = 1;
    }


    // Update is called once per frame
    void Update()
    {

    }
    public void playbutton()
    {
        if (backmusic.isPlaying) return;
        else
        {
            backmusic.Play();
        }
    }
    public void stopbutton()
    {
        backmusic.Stop();
    }
}
