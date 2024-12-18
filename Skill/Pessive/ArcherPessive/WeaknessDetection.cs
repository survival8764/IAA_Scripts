using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaknessDetection : PlayerSkill
{
    private int[] defensePenetrationBonus = { 2, 4, 6, 8, 10 };

    public WeaknessDetection() : base(
        "���� ����",
        "Archer�� ���� ������ ã�� �� ���ҽ�ŵ�ϴ�.",
        5,
        new int[] { 0, 0, 0, 0, 0 },
        new float[] { 0, 0, 0, 0, 0 }
    )
    { }

    public int GetDefensePenetrationBonus()
    {
        return defensePenetrationBonus[Level - 1];
    }
    public override void UseSkill(Hero caster)
    {
        // �нú� ��ų�̹Ƿ� ������ �ƹ� �͵� ���� �ʽ��ϴ�.
    }
}