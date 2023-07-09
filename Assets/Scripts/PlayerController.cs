using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Animator _animator;

    private SpriteRenderer _renderer;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _renderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _animator.SetTrigger("Run");
            _renderer.flipX = false;
            transform.Translate(_speed * Time.deltaTime ,0 ,0 );
        }

        if (Input.GetKey(KeyCode.A))
        {
            _animator.SetTrigger("Run");
            _renderer.flipX = true;
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
        }
    }
}
