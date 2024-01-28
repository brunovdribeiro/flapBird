using UnityEngine;
using System;
using Random = System.Random;

public class Pipe : MonoBehaviour
{
    private const int DeadZone = -13;
    private const int HighestTopPosition = 12;
    private const int LowestTopPosition = 3;
    private const int PipesOffset =14;
    
    public float moveSpeed = 5;
    public GameObject Top;
    public GameObject Bottom;

    private void Start()
    {
        var pos = transform.position;
        var topPositionY = new Random().Next(LowestTopPosition, HighestTopPosition) + pos.y;
        var bottomPositionY = topPositionY - PipesOffset; 

        Top.transform.position = new Vector3(pos.x,  topPositionY);
        Bottom.transform.position = new Vector3(pos.x, bottomPositionY);
        
        
        Debug.Log($"TOP Y: {topPositionY}");
        Debug.Log($"BOTTOM Y: {bottomPositionY}");
    }

    private void Update()
    {
        MoveToLeft();

        if (EnterOnDeadZone())
        {
            DestroyPipe();
        }
    }

    private void DestroyPipe()
    {
        Destroy(gameObject);
    }

    private bool EnterOnDeadZone()
    {
        return transform.position.x <= DeadZone;
    }

    private void MoveToLeft()
    {
        transform.position += Vector3.left * (moveSpeed * Time.deltaTime);
    }
}