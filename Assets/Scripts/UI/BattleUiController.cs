using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class BattleUiController : MonoBehaviour
{
   public TextMeshProUGUI dialogueText;
    public Button attackSelect;
    public Button singleAttack;
    public Button aimedAttack;

    public GameObject mainMenu;
    public GameObject attackMenu;
    public GameObject aimedMenu;

        public Button head;
        public Button torso;
        public Button leftArm;
        public Button rightArm;
        public Button leftLeg;
        public Button RightLeg;


    Screen choice;

   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        choice = Screen.starting;

        SetMenusFalse();
        mainMenu.SetActive(true);


        attackSelect.onClick.AddListener(() => { Attack();});
        aimedAttack.onClick.AddListener(() => AimedAttack());

        singleAttack.onClick.AddListener(() => CompletedAttack());


        head.onClick.AddListener(() => CompletedAttack());
        torso.onClick.AddListener(() => CompletedAttack());
        leftArm.onClick.AddListener(() => CompletedAttack());
        rightArm.onClick.AddListener(() => CompletedAttack());
        leftLeg.onClick.AddListener(() => CompletedAttack());
        RightLeg.onClick.AddListener(() => CompletedAttack());

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Render()
    {
        switch (choice)
        {
            case Screen.starting:
            {
                SetMenusFalse();
                mainMenu.SetActive(true);
                
                break;
            }

            case Screen.choosingAttack:
            {
                SetMenusFalse();
                attackMenu.SetActive(true);
                
                break;
            }

            case Screen.choosingAimed:
            {
                SetMenusFalse();
                aimedMenu.SetActive(true);
                    
                break;
            }
        }
    }

    enum Screen
    {
        starting,
        choosingAttack,
        choosingAimed
    }

    public void Attack()
    {
        choice = Screen.choosingAttack;
        Render();
    }

    public void AimedAttack()
    {
        choice = Screen.choosingAimed;
        Render();
    }

    public void CompletedAttack()
    {
        choice = Screen.starting;
        Render();
    }

    public void SetMenusFalse()
    {
        mainMenu.SetActive(false);
        attackMenu.SetActive(false);
        aimedMenu.SetActive(false);

    }

}
