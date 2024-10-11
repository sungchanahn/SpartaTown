using UnityEngine;

public class LookingLeftCharacterAimRotation : AimRotation
{
    [SerializeField] private SpriteRenderer characterRenderer;

    protected override void RotateCharacter(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        characterRenderer.flipX = !(Mathf.Abs(rotZ) > 90f);
    }
}