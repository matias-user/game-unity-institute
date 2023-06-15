using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHP : MonoBehaviour
{
    [SerializeField] protected float initialHP;
    [SerializeField] protected float maxHP;
    public float ActualHP { get; protected set; }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void TakeDamage(float amountDamage)
    {
        if (amountDamage <= 0) return;

        if (ActualHP > 0) 
        {
            ActualHP -= amountDamage;
            UpdateHPValue(ActualHP, maxHP);
        }else if ( ActualHP <= 0)
        {
            CharacterDefeated();
            UpdateHPValue( ActualHP, maxHP );
        }
        
    }
    protected virtual void CharacterDefeated() { }
    protected virtual void UpdateHPValue(float hpActual, float hpMax) { }
}
