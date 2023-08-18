using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HpUI : MonoBehaviour
{
    public Collider2D Player ;
    public Collider2D Obtacle;
    [Header("HealthParameters")]
    [SerializeField] public float Hpax;
    private float currentHp;

    [Header("UIParameters")]
    [SerializeField] private TMP_Text HpText;

    private float Wait;
    private float CheckInterval = 0.25f;

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
        if (Player.IsTouching(Obtacle))
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
