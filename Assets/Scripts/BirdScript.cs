using System;
using UnityEngine;
using UnityEngine.UIElements;

public class BirdScript : MonoBehaviour
{
    private LogicManagerScript _logicManagerScript;
    private bool IsAlive => !_logicManagerScript.GameOverScreen.activeSelf;
    public Rigidbody2D myRigidBody;
    public float flapStrength = 8;

    private void Start()
    {
        _logicManagerScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    private void Update()
    {
        if (!IsAlive) return;
        
        if (InputDetected())
            Fly();
    }

    private void OnBecameInvisible()
    {
        _logicManagerScript.GameOver();
    }

    private void Fly()
    {
        myRigidBody.velocity = Vector2.up * flapStrength;
    }

    private static bool InputDetected() => IsMouseClicked() || HasTouched();

    private static bool HasTouched()
    {
        if (Input.touchCount <= 0) return false;

        var touch = Input.GetTouch(0);

        return touch.phase == TouchPhase.Began;
    }

    private static bool IsMouseClicked() => Input.GetMouseButtonDown((int)MouseButton.LeftMouse);
}