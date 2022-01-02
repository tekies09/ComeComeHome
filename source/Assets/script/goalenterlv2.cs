using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalenterlv2 : MonoBehaviour
{
    public GameObject char1;
    public GameObject goal;
    public GameObject goaleffect;
    public GameObject clearboard;
    public GameObject resetbutton;
    public GameObject exitbutton;
    public GameObject cheese1;
    public GameObject cheese2;
    public GameObject cheesecrushcheck;
    public GameObject startbutton;
  
    audios2 script;
    
    cheesecheckcode cheesescript;
    movingscript ms;
    Renderer rdgoal, rdgoaleffect,rdcheese1, rdcheese2 , rdgamestart ;
    public float firstx, firsty;
    private Transform tr1, cltr, rbtr1, ebtr1;
    // Start is called before the first frame update
    void Start()
    {  GameObject audio1 = GameObject.Find("buttonclickbgm");
    script = audio1.GetComponent<audios2>();
        rdgamestart = startbutton.GetComponent<Renderer>();
        cheesescript = cheesecrushcheck.GetComponent<cheesecheckcode>();
        rdgoal = goal.GetComponent<Renderer>();
        rdgoaleffect = goaleffect.GetComponent<Renderer>();
        tr1 = char1.GetComponent<Transform>();
        cltr = clearboard.GetComponent<Transform>();
        rbtr1 = resetbutton.GetComponent<Transform>();
        ebtr1 = exitbutton.GetComponent<Transform>();
        rdcheese1 = cheese1.GetComponent<Renderer>();
        rdcheese2 = cheese2.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((cheesescript.cheese1code == 1) && (cheesescript.cheese2code == 1))
        {   script.playbutton();
            rdgamestart.material.color = new Color(rdgamestart.material.color.r, rdgamestart.material.color.g, rdgamestart.material.color.b, 1.0f);
            rdcheese1.material.color = new Color(rdcheese1.material.color.r, rdcheese1.material.color.g, rdcheese1.material.color.b, 1.0f);
            rdcheese2.material.color = new Color(rdcheese2.material.color.r, rdcheese2.material.color.g, rdcheese2.material.color.b, 1.0f);
            tr1.position = new Vector3(firstx, firsty, -5);
            Debug.Log("enter2");
            rdgoal.material.color = new Color(rdgoal.material.color.r, rdgoal.material.color.g, rdgoal.material.color.b, 1.0f);
            rdgoaleffect.material.color = new Color(rdgoaleffect.material.color.r, rdgoaleffect.material.color.g, rdgoaleffect.material.color.b, 1.0f);
            ms = char1.GetComponent<movingscript>();
            ms.gameOncode = 1;
            cltr.position -= new Vector3(0, 9, 0);
            rbtr1.position -= new Vector3(0, 9, 0);
            ebtr1.position -= new Vector3(0, 9, 0);
            cheesescript.cheese1code = 0;
            cheesescript.cheese2code = 0;
            PlayerPrefs.SetInt("second", 1);
        }
    }
}
