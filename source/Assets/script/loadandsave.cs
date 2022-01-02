using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadandsave : MonoBehaviour
{
    public int Loadcode = 0;
    public GameObject level1 = null;
    public GameObject level2 = null;
    public GameObject level3 = null;
    Renderer rdlv1, rdlv2, rdlv3;
    // Start is called before the first frame update
    void Start()
    {
        if (Loadcode == 1)
        {
            Load();
        }
        Debug.Log("loadcode call");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Save(int round)
    {
        if (round == 1)
        {
            PlayerPrefs.SetInt("first", 1);
        }
        else if(round ==2)
        {
            PlayerPrefs.SetInt("second", 1);
        }
        else
        {
            PlayerPrefs.SetInt("third", 1);
        }
    }
    void Load()
    {
        rdlv1 = level1.GetComponent<Renderer>();
        rdlv2 = level2.GetComponent<Renderer>();
        rdlv3 = level3.GetComponent<Renderer>();
        int lv1, lv2, lv3;
        lv1 = PlayerPrefs.GetInt("first");
        lv2 = PlayerPrefs.GetInt("second");
        lv3 = PlayerPrefs.GetInt("third");
        if (lv1 == 1)
        {
            rdlv1.material.color = new Color(rdlv1.material.color.r, rdlv1.material.color.g, rdlv1.material.color.b, 0.5f);
        }
        else
        {
            rdlv1.material.color = new Color(rdlv1.material.color.r, rdlv1.material.color.g, rdlv1.material.color.b, 1.0f);

        }
        if (lv2 == 1)
        {
            rdlv2.material.color = new Color(rdlv2.material.color.r, rdlv2.material.color.g, rdlv2.material.color.b, 0.5f);
        }
        else
        {
            rdlv2.material.color = new Color(rdlv2.material.color.r, rdlv2.material.color.g, rdlv2.material.color.b, 1.0f);

        }
        if (lv3 == 1)
        {
            rdlv3.material.color = new Color(rdlv3.material.color.r, rdlv3.material.color.g, rdlv3.material.color.b, 0.5f);
        }
        else
        {
            rdlv3.material.color = new Color(rdlv3.material.color.r, rdlv3.material.color.g, rdlv3.material.color.b, 1.0f);

        }

    }
}
