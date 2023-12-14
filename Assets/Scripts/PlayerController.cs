using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public Rigidbody _player;
    public float _moveSpeed = 350;

    private void Start() {
        AudioManager.Instance.PlayBgm("Gameplay");
    }

    private void FixedUpdate() {
        PlayerMove();
    }

    private void PlayerMove() {
        float horizontal = Input.GetAxisRaw("Horizontal");

        Vector3 moveDir = new Vector3(horizontal, 0, 0).normalized;

        _player.velocity = moveDir * _moveSpeed * Time.deltaTime;
    }
}
