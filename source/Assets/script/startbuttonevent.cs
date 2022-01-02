using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class startbuttonevent : MonoBehaviour
{
    public GameObject audio1;
    audios2 script;

    
    // Start is called before the first frame update
    void Start()
    {
        script = audio1.GetComponent<audios2>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        script.playbutton();
        SceneManager.LoadScene("lobbyScene");
    }
}
