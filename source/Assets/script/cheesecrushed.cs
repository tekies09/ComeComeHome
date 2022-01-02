using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheesecrushed : MonoBehaviour
{
    public int cheeseno;
    public GameObject cheese;
    cheesecheckcode cheesescript;
    audios2 script;
    // Start is called before the first frame update
    void Start()
    {
        cheesescript = cheese.GetComponent<cheesecheckcode>();
        GameObject audio1 = GameObject.Find("cheesesound");
        script = audio1.GetComponent<audios2>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (cheeseno == 1)
        {
            script.playbutton();
            cheesescript.cheese1code = 1;
        }
        else if (cheeseno == 2)
        {
            script.playbutton();
            cheesescript.cheese2code = 1;
        }
    }
}
