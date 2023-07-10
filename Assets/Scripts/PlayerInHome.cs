using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInHome : MonoBehaviour
{
    [SerializeField] UnityEvent _movementEnter;
    [SerializeField] UnityEvent _movementExit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _movementEnter.Invoke();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _movementExit.Invoke();
    }
}
