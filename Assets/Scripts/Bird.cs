using UnityEngine;
using UnityEngine.UIElements;

public class Bird : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength = 8;

    private void Update()
    {
        if (InputDetected()) Fly();
    }
    private void OnBecameInvisible()
    {
        Debug.Log("O objeto se tornou invisível!");
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