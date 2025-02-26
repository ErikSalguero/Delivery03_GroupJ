using System;
using UnityEngine;

public class AppleHealth : MonoBehaviour
{


    [Range(0, 100)]
    public float Health;
    public float MaxHealth = 100;

    public static Action<float> OnChangeHealth;



    void Start()
    {
        Health = MaxHealth;

        OnChangeHealth?.Invoke(Health / MaxHealth);

    }

    private void OnMouseDown()
    {
        Health -= 10;

        OnChangeHealth?.Invoke(Health / MaxHealth); 
    }


}
