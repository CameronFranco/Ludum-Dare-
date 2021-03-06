﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour {

    private Rigidbody2D rb;

    void Start () {
        rb = gameObject.AddComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        GameObject ship = GameObject.Find("Ship");
        Rigidbody2D ship_rb = ship.GetComponent<Rigidbody2D>();

        rb.AddForce(new Vector2(100f, 0.0f));
        ship_rb.AddForce(new Vector2(100f, 0.0f));

        AudioClip menuMusic = Resources.Load<AudioClip>("Music/MainMenu");
        SoundManager.Instance.LoopMusic(menuMusic);

    }
}
