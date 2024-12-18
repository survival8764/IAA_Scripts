using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveOfHeat : PlayerSkill
{
    private int[] attackSpeedReduction = { 2, 4, 6, 8, 10 };

    public WaveOfHeat() : base(
        "���� �ĵ�",
        "�������� �ű��� ���� �庮�� �����Ͽ� �α� ���� ���� �ӵ��� ���Դϴ�.",
        5,
        new int[] { 0, 0, 0, 0, 0 },
        new float[] { 0, 0, 0, 0, 0 }
    )
    { }

    public int GetAttackSpeedReduction() => attackSpeedReduction[Level - 1];

    public override void UseSkill(Hero caster) { } // �нú� ��ų�̹Ƿ� ����Ӵϴ�.
}