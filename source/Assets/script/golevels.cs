using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class golevels : MonoBehaviour
{
    public int code=0;
    
    audios2 script;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject audio1 = GameObject.Find("buttonclickbgm");
    script = audio1.GetComponent<audios2>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        script.playbutton();
        switch (code)
        {
            case 1 :
                {
                    SceneManager.LoadScene("level1Scene");
                    break;
                }
            case 2:
                {
                    SceneManager.LoadScene("level2Scene");
                    break;
                }
            case 3:
                {
                    SceneManager.LoadScene("level3Scene");
                    break;
                }
            case 4:
                {
                    SceneManager.LoadScene("level4Scene");
                    break;
                }
            case 5:
                {
                    SceneManager.LoadScene("level5Scene");
                    break;
                }
            case 6:
                {
                    SceneManager.LoadScene("level6Scene");
                    break;
                }
            default :
                {
                    break;
                }
        }
 
    }
}
