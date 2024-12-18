using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysticalPower : PlayerSkill
{
    private int[] energyRegeneration = { 2, 4, 6, 8, 10 };

    public MysticalPower() : base(
        "�ź�ο� ��",
        "���� ��ó �������� �������� 1�ʸ��� ȸ����ŵ�ϴ�.",
        5,
        new int[] { 0, 0, 0, 0, 0 },
        new float[] { 0, 0, 0, 0, 0 }
    )
    { }

    public int GetEnergyRegeneration() => energyRegeneration[Level - 1];

    public override void UseSkill(Hero caster) { }
}