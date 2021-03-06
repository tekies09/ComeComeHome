using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lv2startbuttonclick : MonoBehaviour
{
    
    audios2 script;
    
    public GameObject char1;
    public GameObject goal;
    public GameObject goaleffect;
    public GameObject cheese1;
    public GameObject cheese2;
    public GameObject startbutton;
    movingscript ms;
    Renderer rdgoal, rdgoaleffect, rdcheese1, rdcheese2, rdstart;
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
    {script.playbutton();
        rdstart = startbutton.GetComponent<Renderer>();
        ms = char1.GetComponent<movingscript>();
        rdgoal = goal.GetComponent<Renderer>();
        rdgoaleffect = goaleffect.GetComponent<Renderer>();
        rdcheese1 = cheese1.GetComponent<Renderer>();
        rdcheese2 = cheese2.GetComponent<Renderer>();
        ms.gameOncode = 0;
        Debug.Log("lv1startbuttonclicked");
        rdgoal.material.color = new Color(rdgoal.material.color.r, rdgoal.material.color.g, rdgoal.material.color.b, 0.0f);
        rdgoaleffect.material.color = new Color(rdgoaleffect.material.color.r, rdgoaleffect.material.color.g, rdgoaleffect.material.color.b, 0.0f);
        rdcheese1.material.color = new Color(rdcheese1.material.color.r, rdcheese1.material.color.g, rdcheese1.material.color.b, 0.0f);
        rdcheese2.material.color = new Color(rdcheese2.material.color.r, rdcheese2.material.color.g, rdcheese2.material.color.b, 0.0f);
        rdstart.material.color = new Color(rdstart.material.color.r, rdstart.material.color.g, rdstart.material.color.b, 0.0f);
    }
}
