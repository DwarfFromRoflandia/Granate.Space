using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] private float _shakeIntensity; //shake force
    [SerializeField] private float _shakeTime; //shake time

    private float timer;
    private CinemachineVirtualCamera _cinemachineVirtualCamera;
    private CinemachineBasicMultiChannelPerlin _cinemachineBasicMultiChannelPerlin;


    public void Initialize()
    {
        _cinemachineVirtualCamera = GetComponent<CinemachineVirtualCamera>();
        _cinemachineBasicMultiChannelPerlin = _cinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        StopShake();
        EventManager.CameraShakeEvent.AddListener(Shake);
    }

    private void Shake()
    {
        _cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = _shakeIntensity;

        timer = _shakeTime;
    }

    private void StopShake()
    {
        _cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = 0f;

        timer = 0;
    }

    private void Update()
    {
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
