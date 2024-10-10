using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    private TopDownController controller;

    private static readonly int isWalking = Animator.StringToHash("isWalking");
    private readonly float magnituteThreshold = 0.5f;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<TopDownController>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        animator.SetBool(isWalking, direction.magnitude > magnituteThreshold);
    }
}