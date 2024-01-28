using UnityEngine;

public class Pipe : MonoBehaviour
{
    private const int DeadZone = -13;
    public float moveSpeed = 5;


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