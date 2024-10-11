using UnityEngine;

public class AimRotation : MonoBehaviour
{
    protected TopDownController controller;

    protected void Awake()
    {
        controller = GetComponent<TopDownController>();
    }

    protected void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    protected void OnAim(Vector2 direction)
    {
        RotateCharacter(direction);
    }

    protected virtual void RotateCharacter(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
    }
}