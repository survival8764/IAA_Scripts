using System;
using UnityEngine;


public class Enemy : Character
{
    public int expToGive;
    private int attackSpeedReduction = 0;
    protected override void Start()
    {
        SetLayerToEnemy();
        InitializeStats();
        base.Start();
        
    }
    protected virtual void InitializeStats()
    {
        //if (info == null)
        //{
        //    info = new HeroInfo("Enemy", HeroClass.Knight, 0, "");
        //}
        maxHealth = 200;  // �⺻ �� HP
        info.attackDamage = 10;  // �⺻ �� ���ݷ�
        info.attackRange = 1;
        info.energy = 0;
        info.strength = 0;
        info.agility = 0;
        info.intelligence = 0;
        info.stamina = 0;
        info.hp = 200;
        info.defense = 10;
        info.magicResistance = 10;
        info.attackSpeed = 100;
        info.healthRegen = 0;
        info.energyRegen = 5;
        info.expAmplification = 0;
        info.trueDamage = 0;
        info.damageBlock = 0;
        info.lifeSteal = 0;
        info.damageAmplification = 0;
        info.damageReduction = 0;
        info.criticalChance = 100;
        info.criticalDamage = 150;
        info.defensePenetration = 0;

    }
    public void ApplyAttackSpeedReduction(int reduction)
    {
        attackSpeedReduction = reduction;
        UpdateAttackSpeed();
    }
    private void UpdateAttackSpeed()
    {
        // ���� �ӵ� ������Ʈ ����
        // ��: attackInterval = baseAttackInterval * (100 / (100 - attackSpeedReduction));
    }

    private void SetLayerToEnemy()
    {
        int enemyLayer = LayerMask.NameToLayer("Enemy");
        if (enemyLayer != -1)  // "Enemy" ���̾ �����ϴ��� Ȯ��
        {
            gameObject.layer = enemyLayer;

        }

    }
    public override void TakeDamage(Character attacker, float damage)
    {
        
        base.TakeDamage(attacker, damage);
        
    }

    public override void Die()
    {
        if (attacker != null && attacker.info != null)
        {
            attacker.info.AddExp(expToGive);
        }
        base.Die();
        if (dungeon != null)
        {
            dungeon.GetDroppedItem(this.transform);
        }
    }
}
