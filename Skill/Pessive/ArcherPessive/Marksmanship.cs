using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marksmanship : PlayerSkill
{
    private int[] attackSpeedBonus = { 3, 6, 9, 12, 15 };

    public Marksmanship() : base(
        "��ݼ�",
        "Archer�� Ÿ�� ������ �����ϴ� ���� �ӵ��� ������ �ֽ��ϴ�.",
        5,
        new int[] { 0, 0, 0, 0, 0 },
        new float[] { 0, 0, 0, 0, 0 }
    )
    { }

    public int GetAttackSpeedBonus()
    {
        return attackSpeedBonus[Level - 1];
    }
    public override void UseSkill(Hero caster)
    {
        // �нú� ��ų�̹Ƿ� ������ �ƹ� �͵� ���� �ʽ��ϴ�.
    }
}