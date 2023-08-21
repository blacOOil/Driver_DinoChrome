using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HpUI : MonoBehaviour
{
    public Collider2D Player ;
    public LayerMask obtascleMask;
    [Header("HealthParameters")]
    [SerializeField] public float Hpax;
    private float currentHp;

    [Header("UIParameters")]
    [SerializeField] private TMP_Text HpText;

    private float Wait;
    private float CheckInterval = 0.159f;

    private void Start()
    {
        
        currentHp = Hpax;
        UpdateHp();
        Wait = 0f;
    }
    private void Update()
    {
        Wait += Time.deltaTime;
        if(Wait >= CheckInterval)
        {
         CollisioCheck();
            Wait = 0f;
        }
      
        
      
    }

    private void CollisioCheck()
    {
        if (Player.IsTouchingLayers(obtascleMask))
        {
           TakeDamage(1f);
        }
    }
    void UpdateHp()
    {
        HpText.text = currentHp.ToString("0");
    }

    void TakeDamage(float Damage)
    {
        currentHp -= Damage;
        UpdateHp();
    }
}
