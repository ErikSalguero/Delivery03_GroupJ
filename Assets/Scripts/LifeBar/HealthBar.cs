/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Slider slider;
    public Gradient ColorGradient;
    public Image FillImage;

    private void OnEnable()
    {
        AppleHealth.OnChangeHealth += SetValue;
    }

    private void OnDisable()
    {
        AppleHealth.OnChangeHealth -= SetValue;
    }

    void Start()
    {
        slider = GetComponent<Slider>();
        SetValue(1.0f);
    }

    public void SetValue(float fractionHealth)
    {
        slider.value = fractionHealth;
        FillImage.color = ColorGradient.Evaluate(fractionHealth);
        slider.gameObject.SetActive(true);
    }
}
*/