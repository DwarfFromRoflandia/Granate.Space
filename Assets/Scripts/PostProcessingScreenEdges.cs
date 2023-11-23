using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;


public class PostProcessingScreenEdges : MonoBehaviour
{
    [SerializeField] private float _glowTime;
    private float _intensity;

    private PostProcessVolume _volume;
    private Vignette _vignette;

    public void Initialize()
    {
        _volume = GetComponent<PostProcessVolume>();

        _volume.profile.TryGetSettings<Vignette>(out _vignette);

        _vignette.enabled.Override(false);

        EventManager.GlowEdgesScreenEvent.AddListener(GlowEffect);
    }

    private void GlowEffect() => StartCoroutine(GlowEffectCoroutine());

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GlowEffect();

        }
    }

    private IEnumerator GlowEffectCoroutine()
    {
        _intensity = 0.4f;
        _vignette.enabled.Override(true);

        _vignette.intensity.Override(0.4f);

        yield return new WaitForSeconds(_glowTime);

        while (_intensity > 0)
        {
            _intensity -= 0.01f;

            if (_intensity < 0)
            {
                _intensity = 0;
            }

            _vignette.intensity.Override(_intensity);

            yield return new WaitForSeconds(0.1f);
        }

        _vignette.enabled.Override(true);
        yield break;
    }
}
