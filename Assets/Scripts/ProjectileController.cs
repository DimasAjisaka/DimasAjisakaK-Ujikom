using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour {
    public GameObject _projectileSpawn;
    public GameObject _projectile;
    public float _lifeTime = 3;
    public float _moveSpeed = 25;
    public float _hungerValue = 25;

    private void Update() {
        Fire();
    }

    public void Fire() {
        if (Input.GetMouseButtonDown(0)) {
            Debug.Log("Mouse Click");
            AudioManager.Instance.PlaySfx("Fire");
            _projectile.transform.position = new Vector3(0, 1, 0) * _moveSpeed * Time.deltaTime;
            _lifeTime -= Time.deltaTime;
            if (_lifeTime == 0) {
                Destroy(_projectile);
            }
        }
    }
}
