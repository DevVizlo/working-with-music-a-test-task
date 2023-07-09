using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInHome : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    private Coroutine _activeCoroutine;
    private float _recoveryRate = 0.5f;
    private float _requiredValue;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _requiredValue = 1f;
        _audioSource.Play();
        _activeCoroutine = StartCoroutine(ChangeVolume());
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _requiredValue = 0f;
        StopCoroutine(_activeCoroutine);
        _activeCoroutine = StartCoroutine(ChangeVolume());
    }

    private IEnumerator ChangeVolume()
    {
        while (_audioSource.volume != _requiredValue)
        {
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, _requiredValue, _recoveryRate * Time.deltaTime);
            yield return null;
        }

    }
}
