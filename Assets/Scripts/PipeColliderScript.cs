using System;
using UnityEngine;

public class PipeColliderScript : MonoBehaviour
{
    private LogicManagerScript logicManager;

    private void Start()
    {
        logicManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        logicManager.AddScore(1);
    }
}