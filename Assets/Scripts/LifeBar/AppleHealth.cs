/*using System;
using UnityEngine;
using UnityEngine.SceneManagement;

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

        if (Health == 0)
        {
            SceneManager.LoadSceneAsync(2);
        }
    }


}
*/