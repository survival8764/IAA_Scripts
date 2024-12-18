using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysticResonance : PlayerSkill
{
    private float[] skillDamageAmplification = { 0.05f, 0.08f, 0.11f, 0.15f, 0.20f };

    public MysticResonance() : base(
        "�ű��� ����",
        "�������� ��Ƽ�� ��ų �������� ��ȭ��ŵ�ϴ�.",
        5,
        new int[] { 0, 0, 0, 0, 0 },
        new float[] { 0, 0, 0, 0, 0 }
    )
    { }

    public float GetSkillDamageAmplification() => skillDamageAmplification[Level - 1];

    public override void UseSkill(Hero caster) { } // �нú� ��ų�̹Ƿ� ����Ӵϴ�.
}