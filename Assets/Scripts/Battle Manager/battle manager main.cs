using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class battlemanagermain : MonoBehaviour
{
    public int playerHealth = 100;
    public int enemyHealth = 100;
    EnemyInstance enemy;
    public EnemyDefinition enemyBlueprint;
    public Slider playerBar;
    public Slider enemyBar;
    public TextMeshProUGUI dialogueText;

    public Button singleAttack;

        public Button head;
        public Button torso;
        public Button leftArm;
        public Button rightArm;
        public Button leftLeg;
        public Button rightLeg;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemy = new EnemyInstance(enemyBlueprint);

        singleAttack.onClick.AddListener(() => { SingleAttack();});

        head.onClick.AddListener(() => AimedAttack(enemy.def.head));
        torso.onClick.AddListener(() => AimedAttack(enemy.def.torso));
        leftArm.onClick.AddListener(() => AimedAttack(enemy.def.leftArm));
        rightArm.onClick.AddListener(() => AimedAttack(enemy.def.rightArm));
        leftLeg.onClick.AddListener(() => AimedAttack(enemy.def.leftLeg));
        rightLeg.onClick.AddListener(() => AimedAttack(enemy.def.rightLeg));


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SingleAttack()
    {
        enemy.currentHp -= 20;
        enemyBar.value = enemy.currentHp;

    }

    public void AimedAttack(bodyPart part)
    {
        enemy.currentHp -=20;
        part.partHealth -=20;

        Debug.Log($"{part.partName} was hit");
    }

    public class EnemyInstance
    {
        public EnemyDefinition def;
        public int currentHp;

        public EnemyInstance(EnemyDefinition srcDef)
        {
            def = srcDef;
            currentHp = srcDef.totalHp;
            
        }
    }


}
