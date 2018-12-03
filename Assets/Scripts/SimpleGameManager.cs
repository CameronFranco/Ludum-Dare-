﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleGameManager : MonoBehaviour
{
    public GameObject Selected = null;
    bool Island1 = true;
    bool Island2 = false;
    bool Island3 = false;
    bool Island4 = false;
    bool Island5 = false;

    private static SimpleGameManager instance = null;
    public List<GameObject> Crew = new List<GameObject>();
    public static SimpleGameManager Instance
    {
        get
        {
            if (SimpleGameManager.instance == null)
            {
                SimpleGameManager.instance = FindObjectOfType<SimpleGameManager>();
                if (SimpleGameManager.instance == null)
                {
                    GameObject go = new GameObject();
                    go.name = "SimpleGameManager";
                    SimpleGameManager.instance = go.AddComponent<SimpleGameManager>();
                    DontDestroyOnLoad(go);
                }
            }
            return SimpleGameManager.instance;
        }
    }
    // Class Methods
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    //can i got to this island
    public bool IsAlllowed (int island){
        if (island == 1){
            return Island1;
        }if (island == 2){
            return Island2;
        }if (island == 3){
            return Island3;
        }if (island == 4){
            return Island4;
        }if (island == 5){
            return Island5;
        }
         else {
            return false;
        }
    }
    public void visitIsland (int island)
    {
        // Islands go:
        //  1 -> 3 -> 2
        //  1 -> 4 -> 5
        Island1 = false;
        if (island == 2){
            Island2 = false;
            Island3 = false;
            Island4 = false;
            Island5 = false;
        }
        if (island == 4){
            Island2 = false;
            Island3 = false;
            Island4 = false;
            Island5 = true;
        }
        if (island == 3){
            Island2 = true;
            Island3 = false;
            Island4 = false;
            Island5 = false;
        }
        if (island == 5){
            Island2 = false;
            Island3 = false;
            Island4 = false;
            Island5 = false;
        }
    }
    public void AddCrew(GameObject crewmate)
    {
        DontDestroyOnLoad(crewmate);
        Crew.Add(crewmate);
    }
}
