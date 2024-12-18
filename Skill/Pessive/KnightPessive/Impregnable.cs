public class Impregnable : PlayerSkill
{
    private int[] damageReductionBonus = { 3, 6, 9, 12, 15 };

    public Impregnable() : base(
        "�����Ҷ�",
        "���� HP�� 60%���� ������ �޴� ���ذ� �پ��ϴ�.",
        5,
        new int[] { 0, 0, 0, 0, 0 },
        new float[] { 0, 0, 0, 0, 0 }
    )
    {
    }

    public int GetDamageReductionBonus()
    {
        return damageReductionBonus[Level - 1];
    }

    public override void UseSkill(Hero caster) { } // �нú� ��ų�̹Ƿ� ����Ӵϴ�.
}