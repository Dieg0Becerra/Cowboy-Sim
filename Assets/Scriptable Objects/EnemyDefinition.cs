using UnityEngine;

[CreateAssetMenu]

public class EnemyDefinition : ScriptableObject
{
    public string enemyName;
    public int totalHp;
    public int attackDamage;

    public bodyPart head;
    public bodyPart torso;
    public bodyPart leftArm;
    public bodyPart rightArm;
    public bodyPart leftLeg;
    public bodyPart rightLeg;


}


[System.Serializable]
public class bodyPart
{
    public string partName;
    public int partHealth;
}