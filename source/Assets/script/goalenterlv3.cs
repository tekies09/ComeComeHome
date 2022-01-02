using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalenterlv3 : MonoBehaviour
{
   
    audios2 script;
    
    public GameObject char1;
    public GameObject goal;
    public GameObject goaleffect;
    public GameObject clearboard;
    public GameObject resetbutton;
    public GameObject exitbutton;
    public GameObject startbutton;
    public GameObject hole;
    movingscript ms;
    Renderer rdgoal, rdgoaleffect, rdstart , rdhole;
    public float firstx, firsty;
    private Transform tr1, cltr, rbtr1, ebtr1;
    // Start is called before the first frame update
    void Start()
    { GameObject audio1 = GameObject.Find("buttonclickbgm");
    script = audio1.GetComponent<audios2>();
        rdhole = hole.GetComponent<Renderer>();
        rdstart = startbutton.GetComponent<Renderer>();
        rdgoal = goal.GetComponent<Renderer>();
        rdgoaleffect = goaleffect.GetComponent<Renderer>();
        tr1 = char1.GetComponent<Transform>();
        cltr = clearboard.GetComponent<Transform>();
        rbtr1 = resetbutton.GetComponent<Transform>();
        ebtr1 = exitbutton.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
script.playbutton();
        tr1.position = new Vector3(firstx, firsty, -5);
        Debug.Log("enter2");
        rdgoal.material.color = new Color(rdgoal.material.color.r, rdgoal.material.color.g, rdgoal.material.color.b, 1.0f);
        rdgoaleffect.material.color = new Color(rdgoaleffect.material.color.r, rdgoaleffect.material.color.g, rdgoaleffect.material.color.b, 1.0f);
        rdstart.material.color = new Color(rdstart.material.color.r, rdstart.material.color.g, rdstart.material.color.b, 1.0f);
        rdhole.material.color = new Color(rdhole.material.color.r, rdhole.material.color.g, rdhole.material.color.b, 1.0f);
        ms = char1.GetComponent<movingscript>();
        ms.gameOncode = 1;
        cltr.position -= new Vector3(0, 9, 0);
        rbtr1.position -= new Vector3(0, 9, 0);
        ebtr1.position -= new Vector3(0, 9, 0);
        PlayerPrefs.SetInt("third", 1);
    }
}
