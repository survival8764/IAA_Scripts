using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnhancedBow : PlayerSkill
{
    private int[] trueDamageBonus = { 4, 8, 12, 16, 20 };

    public EnhancedBow() : base(
        "��ȭ�� Ȱ",
        "������ Ȱ�� ȭ�쿡 ���� ���ظ� ũ�� ������ŵ�ϴ�. �������� ��� ���ݸ��� �߰� �������ظ� �����ϴ�.",
        5,
        new int[] { 0, 0, 0, 0, 0 },
        new float[] { 0, 0, 0, 0, 0 }
    )
    { }

    public int GetTrueDamageBonus()
    {
        return trueDamageBonus[Level - 1];
    }
    public override void UseSkill(Hero caster)
    {
        // �нú� ��ų�̹Ƿ� ������ �ƹ� �͵� ���� �ʽ��ϴ�.
    }
}