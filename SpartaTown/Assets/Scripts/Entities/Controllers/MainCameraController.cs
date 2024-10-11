using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    [SerializeField] float smoothing = 0.2f;

    private void FixedUpdate()
    {
        if (GameManager.Instance.player.transform == null) return;
        Vector3 targetPos = new Vector3(GameManager.Instance.player.transform.position.x, GameManager.Instance.player.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, smoothing);
    }
}