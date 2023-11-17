using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] private float _shakeIntensity = 1f; //shake force
    [SerializeField] private float _shakeTime = 0.2f; //shake time

    private float timer;
    private CinemachineVirtualCamera _cinemachineVirtualCamera;
    public void Initialize()
    {
        _cinemachineVirtualCamera = GetComponent<CinemachineVirtualCamera>();
        StopShake();
    }

    private void Shake()
    {
        CinemachineBasicMultiChannelPerlin _cinemachineBasicMultiChannelPerlin = _cinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        _cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = _shakeIntensity;

        timer = _shakeTime;
    }

    private void StopShake()
    {
        CinemachineBasicMultiChannelPerlin _cinemachineBasicMultiChannelPerlin = _cinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        _cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = 0f;

        timer = 0;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Shake();
        }

        if (timer > 0)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                StopShake();
            }
        }
    }
}
