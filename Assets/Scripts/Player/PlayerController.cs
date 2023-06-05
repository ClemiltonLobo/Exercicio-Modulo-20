using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //publics
    [Header("Lerp")]
    public Transform target;
    public float lerpSpeed = 1f;
    public float speed = 1f;
    public string tagToCheckEnemy = "Enemy";
    public string tagToCheckEndLine = "EndLine";   

    

    //privates
    private Vector3 _pos;
    private bool _canRun;

    private void Start()
    {
        _canRun = true;
    }

    void Update()
    {
        if(!_canRun) return;
        _pos = target.position;
        _pos.y = transform.position.y;
        _pos.z = transform.position.z;

        transform.position = Vector3.Lerp(transform.position, _pos, lerpSpeed * Time.deltaTime);
        transform.Translate(transform.forward * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == tagToCheckEnemy)
        {
            LoadLoserScene();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == tagToCheckEndLine)
        {
            LoadWinnerScene();
        }
    }

    private void LoadWinnerScene()
    {
        SceneManager.LoadScene("WinnerScene");
    }

    private void LoadLoserScene()
    {
        _canRun = false;
        SceneManager.LoadScene("LoserScene");
    }

    public void StartToRun()
    {
        _canRun=true;
    }
}
