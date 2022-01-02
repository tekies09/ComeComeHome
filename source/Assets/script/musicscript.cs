using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicscript : MonoBehaviour
{

    audios2 script;
    public int musiccode;
    public Sprite musicon, musicoff;
    public GameObject musicbutton;
    SpriteRenderer msrd;
    // Start is called before the first frame update
    void Start()
    {
        GameObject audio1 = GameObject.Find("bgm");
        script = audio1.GetComponent<audios2>();
        msrd = musicbutton.GetComponent<SpriteRenderer>();
        Loadmusic();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (musiccode == 0)
        {
            msrd.sprite = musicon;
            musiccode = musiccode + 1;
            script.playbutton();
        }
        else
        {
            msrd.sprite = musicoff;
            musiccode = musiccode - 1;
            script.stopbutton();
        }
        PlayerPrefs.SetInt("bgm", musiccode);
    }
    void Loadmusic()
    {
        musiccode = PlayerPrefs.GetInt("bgm");
        if (musiccode == 0)
        {
            msrd.sprite = musicoff;
            script.stopbutton();
        }
        else
        {
            msrd.sprite = musicon;
            script.playbutton();
        }
    }
}
