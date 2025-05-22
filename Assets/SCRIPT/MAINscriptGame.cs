using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;
using UnityEngine.Scripting;
using UnityEngine.UI;
using YG;

public class MAINscriptGame : MonoBehaviour
{
    public Button BananaButton;
    public Image BananaImage;
    public Button MainMenuButton;
    public Button ChildButtonMenu;
    public Button BananaSkin1;
    public Button MenuArtifact;
    public Button MenuArtifactButtonImage;

    public Image DarkGoldIamge;
    public TextMeshProUGUI DarkGoldTextMain;

    public Image AutoSaveImage;
    public Button SaveGamrButton;
    private int TimerAutoSave = 60;

    public Button BananaSkin11;
    public Button UlockButtonBananaSkill1;
    public int NumberUnlock = 0;
    private int MaxSkillNumber = 5;
    public int SkillNumber = 0;
    private int MultiNUmber = 2;
    public int LevelPoint = 0;

    public Button BananaSkin2;
    public Button UnlockButtonBananaSkill2;
    private int MaxSkill2Number = 5;
    public int SkillNumber2 = 0;
    public int ScoreMulti = 1;
    public int ScoreMultiChance = 0;

    public Button BananaSkin3;
    public Button UnlockButtonBananaSkill3;
    private int MaxSkill3Number = 7;
    public int SkillNumber3 = 0;
    public int XpMulti = 1;
    public int XpMultiChance = 0;

    public Button BananaSkin4;
    public Button UnlockButtonBananaSkill4;
    private int MaxSkill4Number = 10;
    public int SkillNumber4 = 0;
    public int ScoreClickMulti = 1;

    public Button BananaSkin5;
    public Button UnlockButtonBananaSkill5;
    private int MaxSkill5Number = 1;
    public int SkillNumber5 = 0;

    public Button EquipButtonSkin;
    public Button UpgradeButtonSkin;
    public Image MenuInven;
    public Button BuyButtonBananaSkin;
    public TextMeshProUGUI ScoreBananaText;
    public TextMeshProUGUI SkinDiscription;
    public TextMeshProUGUI UpgradeSkinText;
    public TextMeshProUGUI MinMaxUpgradeText;
    public TextMeshProUGUI GoldText;
    public TextMeshProUGUI SkiSkillDiscription;
    public TextMeshProUGUI SkillUpdateDisc;
    public TextMeshProUGUI ScoreBarText;
    public TextMeshProUGUI LevelPointBarText;
    public TextMeshProUGUI GoldBarText;
    public TextMeshProUGUI XpText;
    public TextMeshProUGUI LevelText;
    public Slider XpSlider;

    private int IdNumber = 0;
    private int IdBuyButtonSkill = 0;
    public double Score = 0;
    public double MaxScore = 0;
    public int Gold = 0;
    public int GoldChance = 0;

    public int DarkGold = 0;

    public double LvlXp = 0;
    public float LvlMaxXp = 100f;
    public int Level = 0;
    public int LvlChance = 30;

    public Sprite[] SkinSelected;

    public Button TreeSkill0;
    public Button InvinsibleButtonSkillTreeLock0;
    public int SkillTreeNumber0 = 0;
    private int SkilTreeMaxNumber0 = 25;
    public int ScoreValueTimePlus = 0;
    public int SkillTreeCost = 500;

    public Button TreeSkill1;
    public Button InvinsibleButtonSkillTreeLock1;
    public int SkillTreeNumber1 = 0;
    private int SkilTreeMaxNumber1 = 25;
    public int GoldValueTimePlus = 0;
    public int SkillTreeCost1 = 1000;

    public Button TreeSkill2;
    public Button InvinsibleButtonSkillTreeLock2;
    public int SkillTreeNumber2 = 0;
    private int SkilTreeMaxNumber2 = 25;
    public int XpValueTimePlus = 0;
    public int SkillTreeCost2 = 1250;

    public Button TreeSkill3;
    public Button InvinsibleButtonSkillTreeLock3;
    public int SkillTreeNumber3 = 0;
    private int SkilTreeMaxNumber3 = 15;
    public int GoldChanceSkillTree = 0;
    public int SkillTreeCost3 = 1500;

    public Button TreeSkill4;
    public Button InvinsibleButtonSkillTreeLock4;
    public Image SkillTreeLock3;
    public int SkillTreeNumber4 = 0;
    private int SkilTreeMaxNumber4 = 25;
    public int GoldMultiSkillTree = 0;
    public int SkillTreeCost4 = 1750;

    public Button TreeSkill5;
    public Button InvinsibleButtonSkillTreeLock5;
    public Image SkillTreeLock4;
    public int SkillTreeNumber5 = 0;
    private int SkilTreeMaxNumber5 = 25;
    public int XpMultiSkillTree = 1;
    public int SkillTreeCost5 = 1500;

    public Button TreeSkill6;
    public Image SkillTreeLock5;
    public int SkillTreeNumber6 = 0;
    private int SkilTreeMaxNumber6 = 1;
    public int SkillTreeCost6 = 3000;

    public Button TreeSkill7;
    public Image SkillTreeLock6;
    public int SkillTreeNumber7 = 0;
    private int SkilTreeMaxNumber7 = 1;
    public int SkillTreeCost7 = 7000;

    public Button TreeSkill8;
    public Image SkillTreeLock7;
    public int SkillTreeNumber8 = 0;
    private int SkilTreeMaxNumber8 = 1;
    public int SkillTreeCost8 = 12000;

    public Button TreeSkill9;
    public Image SkillTreeLock8;
    public int SkillTreeNumber9 = 0;
    private int SkilTreeMaxNumber9 = 1;
    public int DarkGoldChance = 0;
    public int SkillTreeCost9 = 20000;

    public Button TreeSkill10;
    public Image SkillTreeLock9;
    public int SkillTreeNumber10 = 0;
    private int SkilTreeMaxNumber10 = 50;
    public int PlayerHpPlusTree = 2;
    public int SkillTreeCost10 = 250;

    public Button TreeSkill11;
    public Image SkillTreeLock10;
    public int SkillTreeNumber11 = 0;
    private int SkilTreeMaxNumber11 = 50;
    public int PlayerDamageTapPlus = 1;
    public int PLayerDamageTimePlaus = 5;
    public int SkillTreeCost11 = 2500;

    public TextMeshProUGUI DarkGoldText;

    public Image ChildMenuTree;
    public Image ChildTreeUpgradeDiscription;
    public Image SkillTreeLock0;
    public Image SkillTreeLock1;
    public Image SkillTreeLock2;

    public Button SkillTreeUnlock;
    public Button SkillTreeUpgrade;
    public Button SkillTreeAscension;
    public TextMeshProUGUI SkillTreeDiscription;
    public TextMeshProUGUI SkillTreeUpgradeDiscription;
    public TextMeshProUGUI SkillTreeUpgardeText;
    public TextMeshProUGUI SkillTreeCostText;
    public TextMeshProUGUI GoldTextSkillTree;

    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

    public Button MenuCaveButton;
    public Image MenuCaveImage;

    public Slider IronSlider;
    public Button IronButton;
    public TextMeshProUGUI OreIronAmountText;
    public TextMeshProUGUI AmountIngotIronText;
    public float OreIronTime = 20f;
    public float OreIronTimeZero = 0f;
    public int OreIronCostUpgrade = 3000;
    public int OreIronUpgrade = 1;
    public int OreIron = 0;
    public int IngotIron = 0;
    public int OreIronNumber = 1;
    public int OreIronMaxNumber = 15;
    public int OreId = 0;

    public Slider CopperSlider;
    public Button CopperButton;
    public TextMeshProUGUI OreCopperAmountText;
    public TextMeshProUGUI AmountIngotCopperText;
    public float OreCopperTime = 30f;
    public float OreCopperTimeZero = 0f;
    public int OreCopperCostUpgrade = 5000;
    public int OreCopperUpgrade = 1;
    public int OreCopper = 0;
    public int IngotCopper = 0;
    public int OreCopperNumber = 1;
    public int OreCopperMaxNumber = 25;

    public Slider GoldSlider;
    public Button GoldButton;
    public TextMeshProUGUI OreGoldAmountText;
    public TextMeshProUGUI AmountIngotGoldText;
    public float OreGoldTime = 45f;
    public float OreGoldTimeZero = 0f;
    public int OreGoldCostUpgrade = 7000;
    public int OreGoldUpgrade = 1;
    public int OreGold = 0;
    public int IngotGold = 0;
    public int OreGoldNumber = 1;
    public int OreGoldMaxNumber = 40;

    public Button OreUpgradeButton;
    public Button OreFogreButtonMax;
    public TextMeshProUGUI OreNameText;
    public TextMeshProUGUI OreTimeDiscriptionText;
    public TextMeshProUGUI OreCostText;
    public TextMeshProUGUI OreUpgradeDiscriptionTimeText;
    public TextMeshProUGUI OreUpUpgradeText;
    public TextMeshProUGUI OreNumberUpgradeText;


    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!Меню Артифактов!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!//
    public int ArtifId = 0;
    public Button ArtifactButtonUpgarde;
    public Image MetallUpgradeImage;
    public Sprite[] MettallSpriteImage;

    public Button Artifact0;

    public int CheckUnlockArtefact0 = 0;
    public int ArtifactHp0 = 1;
    public int ArtifactDamage0 = 2;
    public int ArtifactCriticalDamageChance0 = 1;
    public float ArtifactDamageTime0 = 0.05f;
    public int ArtifactDamageTap0 = 1;

    public int ArtifactUpgradeNumber0 = 0;
    public int ArtifactUpgradeNumberMax0 = 10;

    public int ArtifactGoldCost0 = 30000;
    public int ArtifactDarkGoldCost0 = 5;
    public int ArtifactScoreCost0 = 50000;
    public int ArtifactIronCost0 = 150;

    public Button Artifact1;

    public int CheckUnlockArtefact1 = 0;
    public int ArtifactHp1 = 25;

    public int ArtifactUpgradeNumber1 = 0;
    public int ArtifactUpgradeNumberMax1 = 15;

    public int ArtifactGoldCost1 = 40000;
    public int ArtifactDarkGoldCost1 = 10;
    public int ArtifactScoreCost1 = 100000;
    public int ArtifactCopperCost1 = 200;

    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!Меню Сражений!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!//

    public TextMeshProUGUI PlayerStatText;
    public TextMeshProUGUI PlayerStatHpText;
    public TextMeshProUGUI PlayerStatDamageText;
    public TextMeshProUGUI PlayerStatDamageTapText;
    public TextMeshProUGUI PlayerStatChanceDamageText;
    public TextMeshProUGUI PlayerStatDamageTimeText;

    public TextMeshProUGUI ArtifNameText;
    public TextMeshProUGUI ArtifHpUpText;
    public TextMeshProUGUI ArtifDamageUpText;
    public TextMeshProUGUI ArtifCriticalChanceUpText;
    public TextMeshProUGUI ArtifDamageTimeUpText;
    public TextMeshProUGUI ArtifDamageTapText;

    public TextMeshProUGUI UpgardeDiscriptionText;
    public TextMeshProUGUI GoldArtifUpgradeText;
    public TextMeshProUGUI DarkGoldArtifUpgradeText;
    public TextMeshProUGUI ScoreArtifUpgradeText;
    public TextMeshProUGUI MetallArtifUpgradeText;

    public TextMeshProUGUI upgardeNumber;

    public int PLayerHp = 10;
    public int PlayerMaxHp = 10;

    public int PlayerDamage = 5;
    public int PlayerDamageTap = 1;

    public int PlayerCriticalDamageMulti = 2;
    public int PlayerCriticalDamageChance = 1;

    public float PlayerDamageTime = 10;
    public float PlayerEnemyDamageTime = 0;

    //!!!!!СтатыМонстров!!!!!!!!!!!//
    public int EnemyHp = 20;
    public int EnemyMaxHp = 20;

    public int EnemyDamage = 5;

    public int EnemyCriticalDamageMulti = 2;
    public int EnemyCriticalDamageChance = 1;

    public float EnemyDamageTime = 5;
    public float EnemyDamageTimeZero = 0;

    private int SkillTreeId = 0;

    //!!!!!!!!!!!!!!!!!!!!!!!!!Arena Menu!!!!!!!!!!!!!!!!!!!!!!!!!!!!//

    public Button EnemyButton;
    public Image EnemyImageButton;
    public Sprite[] EnemyRandomSkin;


    public Button ArenaMenu;
    public Button ArenaMenuButtonImage;

    public Slider PlayerHpSlider;
    public Slider EnemyHpSlider;
    public Slider EnemyTimeSlider;

    public TextMeshProUGUI PlayerHpText;
    public TextMeshProUGUI EnemyHpText;

    public TextMeshProUGUI GoldAreanText;
    public TextMeshProUGUI XpArenaText;
    public TextMeshProUGUI ScoreArenaText;

    public TextMeshProUGUI WaveArenaText;
    public TextMeshProUGUI EnemyKillsArenaTExt;

    public int Wave = 1;
    public int MaxWave = 1;
    public int EnemyKills = 0;


    // Start is called before the first frame update
    void Start()
    {
        if (YandexGame.SDKEnabled == true)
        {
            GetLoad();
        }

        AutoSaveImage.gameObject.SetActive(false);

        MainMenuButton.interactable = false;
        ChildButtonMenu.interactable = false;
        MenuCaveButton.interactable = false;
        MenuArtifact.interactable = false;

        Artifact0.interactable = false;
        //Artifact1.interactable = false;
        ArtifactButtonUpgarde.interactable = false;

        SkillTreeAscension.interactable = false;
        SkillTreeUnlock.interactable = false;
        SkillTreeUpgrade.interactable = false;
        SkillTreeDiscription.text = "...";
        SkillTreeUpgradeDiscription.text = "...";
        SkillTreeUpgardeText.text = "...";
        SkillTreeCostText.text = "...";

        CopperButton.interactable = false;
        GoldButton.interactable = false;

        ChildMenuTree.gameObject.SetActive(false);
        ChildTreeUpgradeDiscription.gameObject.SetActive(false);

        MenuArtifactButtonImage.gameObject.SetActive(false);

        ArenaMenuButtonImage.gameObject.SetActive(false);

        DarkGoldText.gameObject.SetActive(false);

        MenuCaveImage.gameObject.SetActive(false);

        MenuInven.gameObject.SetActive(false);

        StartCoroutine(IncrementOverTime());

        UpdateUi();

        StartCoroutine(OreTimer());
    }

    void Update()
    {

    }

    public void OpenMainMenu()
    {
        if (MenuInven.gameObject.activeSelf)
        {
            MenuInven.gameObject.SetActive(false);
        }
        else
        {
            MenuInven.gameObject.SetActive(true);
            ChildMenuTree.gameObject.SetActive(false);
            ChildTreeUpgradeDiscription.gameObject.SetActive(false);
            MenuCaveImage.gameObject.SetActive(false);
            MenuArtifactButtonImage.gameObject.SetActive(false);
            ArenaMenuButtonImage.gameObject.SetActive(false);
        }        
        EquipButtonSkin.interactable = false;
        UpgradeButtonSkin.interactable = false;
        //UlockButtonBananaSkill1.interactable = false;
        BuyButtonBananaSkin.interactable = false;
    }

    public void OpenSkillTreeMenu()
    {
        if (ChildMenuTree.gameObject.activeSelf)
        {
            ChildMenuTree.gameObject.SetActive(false);
            ChildTreeUpgradeDiscription.gameObject.SetActive(false);
        }
        else
        {
            ChildMenuTree.gameObject.SetActive(true);
            ChildTreeUpgradeDiscription.gameObject.SetActive(true);
            MenuInven.gameObject.SetActive(false);
            MenuCaveImage.gameObject.SetActive(false);
            MenuArtifactButtonImage.gameObject.SetActive(false);
            ArenaMenuButtonImage.gameObject.SetActive(false);
        }
        GoldTextSkillTree.text = "Золото:" + Gold;
        DarkGoldText.text = "Наследие:" + DarkGold;
    }

    public void OpenCaveMenu()
    {
        if (MenuCaveImage.gameObject.activeSelf)
        {
            MenuCaveImage.gameObject.SetActive(false);
        }
        else
        {
            MenuCaveImage.gameObject.SetActive(true);
            MenuInven.gameObject.SetActive(false);
            ChildMenuTree.gameObject.SetActive(false);
            ChildTreeUpgradeDiscription.gameObject.SetActive(false);
            MenuArtifactButtonImage.gameObject.SetActive(false);
            ArenaMenuButtonImage.gameObject.SetActive(false);
        }
        OreUpgradeButton.interactable = false;
        OreIronAmountText.text = "" + OreIron;
        AmountIngotIronText.text = "" + IngotIron;

        OreCopperAmountText.text = "" + OreCopper;
        AmountIngotCopperText.text = "" + IngotCopper;

        OreGoldAmountText.text = "" + OreGold;
        AmountIngotGoldText.text = "" + IngotGold;
    }

    public void OpenArtifactMenu()
    {
        if (MenuArtifactButtonImage.gameObject.activeSelf)
        {
            MenuArtifactButtonImage.gameObject.SetActive(false);
        }
        else
        {
            MenuArtifactButtonImage.gameObject.SetActive(true);
            ChildTreeUpgradeDiscription.gameObject.SetActive(false);
            MenuInven.gameObject.SetActive(false);
            MenuCaveImage.gameObject.SetActive(false);
            ChildMenuTree.gameObject.SetActive(false);
            ArenaMenuButtonImage.gameObject.SetActive(false);
        }

        ArtifactButtonUpgarde.interactable = false;

        PlayerStatText.text = "Характеристики";
        PlayerStatHpText.text = PlayerMaxHp + ":";
        PlayerStatDamageText.text = PlayerDamage + ":";
        PlayerStatDamageTapText.text = PlayerDamageTap + ":";
        PlayerStatChanceDamageText.text = PlayerCriticalDamageChance + ":";
        PlayerStatDamageTimeText.text = PlayerDamageTime + ":";

        ArtifNameText.text = "...";
        ArtifHpUpText.text = "...";
        ArtifDamageUpText.text = "...";
        ArtifCriticalChanceUpText.text = "...";
        ArtifDamageTimeUpText.text = "...";
        ArtifDamageTapText.text = "...";

        UpgardeDiscriptionText.text = "Стоимость улучшения";
        GoldArtifUpgradeText.text = "...";
        DarkGoldArtifUpgradeText.text = "...";
        ScoreArtifUpgradeText.text = "...";
        MetallArtifUpgradeText.text = "...";
    }

    public void OpenArenaMenu()
    {
        if (ArenaMenuButtonImage.gameObject.activeSelf)
        {
            ArenaMenuButtonImage.gameObject.SetActive(false);
        }
        else
        {
            ArenaMenuButtonImage.gameObject.SetActive(true);
            MenuArtifactButtonImage.gameObject.SetActive(false);
            ChildTreeUpgradeDiscription.gameObject.SetActive(false);
            MenuInven.gameObject.SetActive(false);
            MenuCaveImage.gameObject.SetActive(false);
            ChildMenuTree.gameObject.SetActive(false);
        }
        PlayerHpText.text = PLayerHp + "|" + PlayerMaxHp;
        EnemyHpText.text = EnemyHp + "|" + EnemyMaxHp;
        GoldAreanText.text = ":" + Gold;
        XpArenaText.text = ":" + LvlXp;
        ScoreArenaText.text = ":" + Score;
        WaveArenaText.text = "Волна:" + Wave;
        EnemyKillsArenaTExt.text = "" + EnemyKills;
        UpdateHpSlider();
        UpdateEnemyHpSlider();
    }

    public void SkinsEquip(int id)
    {      
        if (id == 0)
        {
            SkinDiscription.text = "Обычный банан, ничего необычного";
            UpgradeSkinText.text = "Макс";
            SkiSkillDiscription.text = "Его не надо улучшать, он итак прекрасен!";
            SkillUpdateDisc.text = "...";
            MinMaxUpgradeText.text = "Макс";           
            UpgradeButtonSkin.interactable = false;
            if (BananaImage.sprite == SkinSelected[id])
            {
                EquipButtonSkin.interactable = false;
            }
            else
            {
                EquipButtonSkin.interactable = true;
            }
            YandexGame.savesData.ActualSkin = id;
            IdNumber = 0;
        }

        if (id == 1)
        {
            SkinDiscription.text = "Обычный воришка, может с некоторым шансом дать золото";
            UpgradeSkinText.text = "Улучшить";
            SkiSkillDiscription.text = "Стоимость улучшения: " + 1 + " Очко опыта";
            MinMaxUpgradeText.text = "" + SkillNumber + "/" + MaxSkillNumber;
            SkillUpdateDisc.text = "" + SkillNumber * 5 + "%" + " -> " + (SkillNumber * 5 + 5) + "%";
            UpgradeButtonSkin.interactable = true;

            if (BananaImage.sprite == SkinSelected[id])
            {
                EquipButtonSkin.interactable = false;
            }
            else
            {
                EquipButtonSkin.interactable = true;
            }
          
            if (SkillNumber == MaxSkillNumber)
            {
                SkillUpdateDisc.text = "25% МАКС";
                UpgradeButtonSkin.interactable = false;
                SkiSkillDiscription.text = "Молодец!";
                UpgradeSkinText.text = "Макс";
            }
            YandexGame.savesData.ActualSkin = id;
            IdNumber = 1;
        }

        if (id == 2)
        {
            SkinDiscription.text = "Дальний родственник Бананчика, Воин, немного глуповат, но очень силен, увеличит получаемый счет";
            UpgradeSkinText.text = "Улучшить";
            SkiSkillDiscription.text = "Стоимость улучшения: " + 1 + " Очко опыта";
            MinMaxUpgradeText.text = "" + SkillNumber2 + "/" + MaxSkill2Number;
            SkillUpdateDisc.text = "" + (SkillNumber2 + 1) + "X" + " -> " + (SkillNumber2 + 2) + "X";
            UpgradeButtonSkin.interactable = true;
            if (BananaImage.sprite == SkinSelected[id])
            {
                EquipButtonSkin.interactable = false;
            }
            else
            {
                EquipButtonSkin.interactable = true;
            }

            if (SkillNumber2 == MaxSkill2Number)
            {
                SkillUpdateDisc.text = "6X МАКС";
                UpgradeButtonSkin.interactable = false;
                SkiSkillDiscription.text = "Умничка!";
                UpgradeSkinText.text = "Макс";
            }
            YandexGame.savesData.ActualSkin = id;
            IdNumber = 2;
        }

        if (id == 3)
        {
            SkinDiscription.text = "Умнейший из живущих, он тут затем, чтобы помочь тебе, увеличивает получаемый опыт";
            UpgradeSkinText.text = "Улучшить";
            SkiSkillDiscription.text = "Стоимость улучшения: " + 1 + " Очко опыта";
            MinMaxUpgradeText.text = "" + SkillNumber3 + "/" + MaxSkill3Number;
            SkillUpdateDisc.text = "" + (SkillNumber3 + 1) + "X" + " -> " + (SkillNumber3 + 2) + "X";
            UpgradeButtonSkin.interactable = true;
            if (BananaImage.sprite == SkinSelected[id])
            {
                EquipButtonSkin.interactable = false;
            }
            else
            {
                EquipButtonSkin.interactable = true;
            }

            if (SkillNumber3 == MaxSkill3Number)
            {
                SkillUpdateDisc.text = "8X МАКС";
                UpgradeButtonSkin.interactable = false;
                SkiSkillDiscription.text = "Великолепно!";
                UpgradeSkinText.text = "Макс";
            }
            YandexGame.savesData.ActualSkin = id;
            IdNumber = 3;
        }

        if (id == 4)
        {
            SkinDiscription.text = "Ну разве он не милашка, правда его взгляды на жизнь немного другие, а что еще взять с некромантов";
            UpgradeSkinText.text = "Улучшить";
            SkiSkillDiscription.text = "Стоимость улучшения: " + 1 + " Очко опыта";
            MinMaxUpgradeText.text = "" + SkillNumber4 + "/" + MaxSkill4Number;
            SkillUpdateDisc.text = "" + (SkillNumber4 + 1) + "X" + " -> " + (SkillNumber4 + 2) + "X";
            UpgradeButtonSkin.interactable = true;
            if (BananaImage.sprite == SkinSelected[id])
            {
                EquipButtonSkin.interactable = false;
            }
            else
            {
                EquipButtonSkin.interactable = true;
            }

            if (SkillNumber4 == MaxSkill4Number)
            {
                SkillUpdateDisc.text = "11X МАКС";
                UpgradeButtonSkin.interactable = false;
                SkiSkillDiscription.text = "Потрясающе!";
                UpgradeSkinText.text = "Макс";
            }
            YandexGame.savesData.ActualSkin = id;
            IdNumber = 4;
        }

        if (id == 5)
        {
            SkinDiscription.text = "Отец всех детей, прородитель не от мира сего, озарит тебя великими знаниями о своих детях";
            UpgradeSkinText.text = "Улучшить";
            SkiSkillDiscription.text = "Стоимость улучшения: " + 2 + " Очко опыта";
            MinMaxUpgradeText.text = "" + SkillNumber5 + "/" + MaxSkill5Number;
            SkillUpdateDisc.text = "" + SkillNumber5 + " -> " + MaxSkill5Number;
            UpgradeButtonSkin.interactable = true;
            if (BananaImage.sprite == SkinSelected[id])
            {
                EquipButtonSkin.interactable = false;
            }
            else
            {
                EquipButtonSkin.interactable = true;
            }

            if (SkillNumber5 == MaxSkill5Number)
            {
                SkillUpdateDisc.text = "МАКС";
                UpgradeButtonSkin.interactable = false;
                SkiSkillDiscription.text = "Знания получены!";
                UpgradeSkinText.text = "Макс";
            }
            YandexGame.savesData.ActualSkin = id;
            IdNumber = 5;
        }
        YandexGame.SaveProgress();
    }

    public void EqupButton()
    {
        BananaImage.sprite = SkinSelected[IdNumber];
        EquipButtonSkin.interactable = false;
    }

    public void Unlock1(int BuySkillId)
    {
        if (BuySkillId == 50)
        {
            SkinDiscription.text = "Бананчик стоит 50 очков счета";
            MinMaxUpgradeText.text = "...";
            BuyButtonBananaSkin.interactable = true;
            IdBuyButtonSkill = 50;
        }

        if (BuySkillId == 300)
        {
            SkinDiscription.text = "Бананчик стоит чуть дороже, вываливай 300 очков";
            MinMaxUpgradeText.text = "...";
            BuyButtonBananaSkin.interactable = true;
            IdBuyButtonSkill = 300;
        }

        if (BuySkillId == 2000)
        {
            SkinDiscription.text = "Маг нашел себя не на помойке, плати 2000 очков счета";
            MinMaxUpgradeText.text = "...";
            BuyButtonBananaSkin.interactable = true;
            IdBuyButtonSkill = 2000;
        }

        if (BuySkillId == 5000)
        {
            SkinDiscription.text = "Его любовь это души и твои очки, пока он не забрал твою душу, будь добр, 5000 очков";
            MinMaxUpgradeText.text = "...";
            BuyButtonBananaSkin.interactable = true;
            IdBuyButtonSkill = 5000;
        }

        if (BuySkillId == 250)
        {
            SkinDiscription.text = "Дед Банан и не мечтал о таком, ведь у него не было 250 очков";
            MinMaxUpgradeText.text = "...";
            BuyButtonBananaSkin.interactable = true;
            IdBuyButtonSkill = 250;
        }
    }

    public void BuyButtonSkin()
    {      
        if (IdBuyButtonSkill == 50)
        {
            if (Score >= IdBuyButtonSkill)
            {
                Score -= IdBuyButtonSkill;
                SkillNumber += 1;
                GoldChance += 5;
                MultiNUmber += 1;
                MinMaxUpgradeText.text = "" + SkillNumber + "/" + MaxSkillNumber;
                //SkillUpdateDisc.text = "" + SkillNumber * 5 + "%" + " -> " + (SkillNumber * 5 + 5) + "%";
                SkillUpdateDisc.text = "...";
                UlockButtonBananaSkill1.gameObject.SetActive(false);
                BuyButtonBananaSkin.interactable = false;
                YandexGame.savesData.BananaButtonSkillSave = false;
            }
        }

        if (IdBuyButtonSkill == 300)
        {
            if (Score >= IdBuyButtonSkill)
            {
                Score -= IdBuyButtonSkill;
                SkillNumber2 += 1;
                ScoreMulti += 1;
                ScoreMultiChance += 10;
                MinMaxUpgradeText.text = "" + SkillNumber2 + "/" + MaxSkill2Number;
                //SkillUpdateDisc.text = "" + (SkillNumber2 + 1) + "X" + " -> " + (SkillNumber2 + 2) + "X";
                SkillUpdateDisc.text = "...";
                UnlockButtonBananaSkill2.gameObject.SetActive(false);
                BuyButtonBananaSkin.interactable = false;
                YandexGame.savesData.BananaButtonSkill2Save = false;
            }
        }

        if (IdBuyButtonSkill == 2000)
        {
            if (Score >= IdBuyButtonSkill)
            {
                Score -= IdBuyButtonSkill;
                SkillNumber3 += 1;
                XpMulti += 1;
                XpMultiChance += 10;
                MinMaxUpgradeText.text = "" + SkillNumber3 + "/" + MaxSkill3Number;
                //SkillUpdateDisc.text = "" + (SkillNumber2 + 1) + "X" + " -> " + (SkillNumber2 + 2) + "X";
                SkillUpdateDisc.text = "...";
                UnlockButtonBananaSkill3.gameObject.SetActive(false);
                BuyButtonBananaSkin.interactable = false;
                YandexGame.savesData.BananaButtonSkill3Save = false;
            }
        }

        if (IdBuyButtonSkill == 5000)
        {
            if (Score >= IdBuyButtonSkill)
            {
                Score -= IdBuyButtonSkill;
                SkillNumber4 += 1;
                ScoreClickMulti += 1;
                MinMaxUpgradeText.text = "" + SkillNumber4 + "/" + MaxSkill4Number;
                //SkillUpdateDisc.text = "" + (SkillNumber2 + 1) + "X" + " -> " + (SkillNumber2 + 2) + "X";
                SkillUpdateDisc.text = "...";
                UnlockButtonBananaSkill4.gameObject.SetActive(false);
                BuyButtonBananaSkin.interactable = false;
                YandexGame.savesData.BananaButtonSkill4Save = false;
            }
        }

        if (IdBuyButtonSkill == 250)
        {
            if (Score >= IdBuyButtonSkill)
            {
                Score -= IdBuyButtonSkill;
                MinMaxUpgradeText.text = "" + SkillNumber5 + "/" + MaxSkill5Number;
                SkillUpdateDisc.text = "...";
                UnlockButtonBananaSkill5.gameObject.SetActive(false);
                BuyButtonBananaSkin.interactable = false;
                YandexGame.savesData.BananaButtonSkill5Save = false;
            }
        }
        YandexGame.SaveProgress();
        UpdateUi();
    }

    public void UpgradeSkillSkin()
    {
        if (IdNumber == 1)
        {
            if (LevelPoint >= 1)
            {
                LevelPoint -= 1;
                SkillNumber += 1;
                GoldChance += 5;
                MinMaxUpgradeText.text = "" + SkillNumber + "/" + MaxSkillNumber;
                SkillUpdateDisc.text = "" + SkillNumber * 5 + "%" + " -> " + (SkillNumber * 5 + 5) + "%";
            }
            if (SkillNumber == MaxSkillNumber)
            {
                SkillUpdateDisc.text = "25% МАКС";
                UpgradeButtonSkin.interactable = false;
                SkiSkillDiscription.text = "Молодец!";
                UpgradeSkinText.text = "Макс";
            }
        }

        if (IdNumber == 2)
        {
            if (LevelPoint >= 1)
            {
                LevelPoint -= 1;
                SkillNumber2 += 1;
                ScoreMulti += 1;
                ScoreMultiChance += 10;
                MinMaxUpgradeText.text = "" + SkillNumber2 + "/" + MaxSkill2Number;
                SkillUpdateDisc.text = "" + (SkillNumber2 + 1) + "X" + " -> " + (SkillNumber2 + 2) + "X";
            }
            if (SkillNumber2 == MaxSkill2Number)
            {
                SkillUpdateDisc.text = "6X МАКС";
                UpgradeButtonSkin.interactable = false;
                SkiSkillDiscription.text = "Умничка!";
                UpgradeSkinText.text = "Макс";
            }
        }

        if (IdNumber == 3)
        {
            if (LevelPoint >= 1)
            {
                LevelPoint -= 1;
                SkillNumber3 += 1;
                XpMulti += 1;
                XpMultiChance += 10;
                MinMaxUpgradeText.text = "" + SkillNumber3 + "/" + MaxSkill3Number;
                SkillUpdateDisc.text = "" + (SkillNumber3 + 1) + "X" + " -> " + (SkillNumber3 + 2) + "X";
            }
            if (SkillNumber3 == MaxSkill3Number)
            {
                SkillUpdateDisc.text = "8X МАКС";
                UpgradeButtonSkin.interactable = false;
                SkiSkillDiscription.text = "Великолепно!";
                UpgradeSkinText.text = "Макс";
            }
        }

        if (IdNumber == 4)
        {
            if (LevelPoint >= 1)
            {
                LevelPoint -= 1;
                SkillNumber4 += 1;
                ScoreClickMulti += 1;
                MinMaxUpgradeText.text = "" + SkillNumber4 + "/" + MaxSkill4Number;
                SkillUpdateDisc.text = "" + (SkillNumber4 + 1) + "X" + " -> " + (SkillNumber4 + 2) + "X";
            }
            if (SkillNumber4 == MaxSkill4Number)
            {
                SkillUpdateDisc.text = "11X МАКС";
                UpgradeButtonSkin.interactable = false;
                SkiSkillDiscription.text = "Потрясающе!";
                UpgradeSkinText.text = "Макс";
            }
        }

        if (IdNumber == 5)
        {
            if (LevelPoint >= 2)
            {
                LevelPoint -= 2;
                SkillNumber5 += 1;
                MinMaxUpgradeText.text = "" + SkillNumber5 + "/" + MaxSkill5Number;
                SkillUpdateDisc.text = "" + SkillNumber5 + " -> " + MaxSkill5Number;
            }
            if (SkillNumber5 == MaxSkill5Number)
            {
                SkillUpdateDisc.text = "МАКС";
                UpgradeButtonSkin.interactable = false;
                ChildButtonMenu.interactable = true;
                SkiSkillDiscription.text = "Потрясающе!";
                UpgradeSkinText.text = "Макс";
            }
        }
        UpdateUi();
    }

    //!!!!!!!!!!!!!!!!!!!!!!!!!!Меню Древа Навыков!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

    public void TreeSkill(int id)
    {
        if (id == 0)
        {
            SkillTreeUpgrade.interactable = true;
            SkillTreeUnlock.interactable = false;
            SkillTreeDiscription.text = "Малютка банан,чаще всего он спокоен, но если его тронуть, буйство его бесконечных сил проснется. Он начнет добывать тебе очки счета";
            SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber0 + "/" + SkilTreeMaxNumber0;
            SkillTreeUpgardeText.text = "" + ScoreValueTimePlus + " -> " + (ScoreValueTimePlus + 1);
            SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost);
            GoldTextSkillTree.text = "Золото:" + Gold;
            SkillTreeId = 0;
            if (SkillTreeNumber0 == SkilTreeMaxNumber0)
            {
                SkillTreeUpgrade.interactable = false;
                SkillTreeUpgardeText.text = "МАКС";
                SkillTreeCostText.text = "МАКС";
            }
        }

        if (id == 1)
        {
            SkillTreeUpgrade.interactable = true;
            SkillTreeUnlock.interactable = false;
            SkillTreeDiscription.text = "Приют, бедность, воровство, всё это ему знакомо, он же просто пытается заработать себе на жизнь. Воришка добывает золото";
            SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber1 + "/" + SkilTreeMaxNumber1;
            SkillTreeUpgardeText.text = "" + GoldValueTimePlus + " -> " + (GoldValueTimePlus + 1);
            SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost1);
            GoldTextSkillTree.text = "Золото:" + Gold;
            SkillTreeId = 1;
            if (SkillTreeNumber1 == SkilTreeMaxNumber1)
            {
                SkillTreeUpgrade.interactable = false;
                SkillTreeUpgardeText.text = "МАКС";
                SkillTreeCostText.text = "МАКС";
            }
        }

        if (id == 2)
        {
            SkillTreeUpgrade.interactable = true;
            SkillTreeUnlock.interactable = false;
            SkillTreeDiscription.text = "Желторотик и магического колледжа, он умеет только превращать воду в виски и помогать тебе получать опыт";
            SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber2 + "/" + SkilTreeMaxNumber2;
            SkillTreeUpgardeText.text = "" + XpValueTimePlus + " -> " + (XpValueTimePlus + 1);
            SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost2);
            GoldTextSkillTree.text = "Золото:" + Gold;
            SkillTreeId = 2;
            if (SkillTreeNumber2 == SkilTreeMaxNumber2)
            {
                SkillTreeUpgrade.interactable = false;
                SkillTreeUpgardeText.text = "МАКС";
                SkillTreeCostText.text = "МАКС";
            }
        }

        if (id == 3)
        {
            SkillTreeUpgrade.interactable = true;
            SkillTreeUnlock.interactable = false;
            SkillTreeDiscription.text = "Звонкая монета всегда радует глаз, поможет тебе быстрее находить монеты";
            SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber3 + "/" + SkilTreeMaxNumber3;
            SkillTreeUpgardeText.text = "" + GoldChanceSkillTree + "%" + " -> " + (GoldChanceSkillTree + 5) + "%";
            SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost3);
            GoldTextSkillTree.text = "Золото:" + Gold;
            SkillTreeId = 3;
            if (SkillTreeNumber3 == SkilTreeMaxNumber3)
            {
                SkillTreeUpgrade.interactable = false;
                SkillTreeUpgardeText.text = "МАКС";
                SkillTreeCostText.text = "МАКС";
            }
        }

        if (id == 4)
        {
            SkillTreeUpgrade.interactable = true;
            SkillTreeUnlock.interactable = false;
            SkillTreeDiscription.text = "Одна монета хорошо, но когда их много, гораздо лучше, позвлит увелить находимое количсетво монет";
            SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber4 + "/" + SkilTreeMaxNumber4;
            SkillTreeUpgardeText.text = "" + GoldMultiSkillTree + "X" + " -> " + (GoldMultiSkillTree + 1) + "X";
            SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost4);
            GoldTextSkillTree.text = "Золото:" + Gold;
            SkillTreeId = 4;
            if (SkillTreeNumber4 == SkilTreeMaxNumber4)
            {
                SkillTreeUpgrade.interactable = false;
                SkillTreeUpgardeText.text = "МАКС";
                SkillTreeCostText.text = "МАКС";
            }
        }

        if (id == 5)
        {
            SkillTreeUpgrade.interactable = true;
            SkillTreeUnlock.interactable = false;
            SkillTreeDiscription.text = "Этот мешочек прсто великолепен, он дарует тебе возможость получать больше опыта за клик";
            SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber5 + "/" + SkilTreeMaxNumber5;
            SkillTreeUpgardeText.text = "" + XpMultiSkillTree + "X" + " -> " + (XpMultiSkillTree + 1) + "X";
            SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost5);
            GoldTextSkillTree.text = "Золото:" + Gold;
            SkillTreeId = 5;
            if (SkillTreeNumber5 == SkilTreeMaxNumber5)
            {
                SkillTreeUpgrade.interactable = false;
                SkillTreeUpgardeText.text = "МАКС";
                SkillTreeCostText.text = "МАКС";
            }
        }

        if (id == 6)
        {
            SkillTreeUpgrade.interactable = true;
            SkillTreeUnlock.interactable = false;
            SkillTreeDiscription.text = "Заброшенная потомками шахта, но какие-то ресурсы там точно есть";
            SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber6 + "/" + SkilTreeMaxNumber6;
            SkillTreeUpgardeText.text = "...";
            SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost6);
            GoldTextSkillTree.text = "Золото:" + Gold;
            SkillTreeId = 6;
            if (SkillTreeNumber6 == SkilTreeMaxNumber6)
            {
                SkillTreeUpgrade.interactable = false;
                SkillTreeUpgardeText.text = "МАКС";
                SkillTreeCostText.text = "МАКС";
            }
        }

        if (id == 7)
        {
            SkillTreeUpgrade.interactable = true;
            SkillTreeUnlock.interactable = false;
            SkillTreeDiscription.text = "Медь, хороший метериал для разных вещей";
            SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber7 + "/" + SkilTreeMaxNumber7;
            SkillTreeUpgardeText.text = "...";
            SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost7);
            GoldTextSkillTree.text = "Золото:" + Gold;
            SkillTreeId = 7;
            if (SkillTreeNumber7 == SkilTreeMaxNumber7)
            {
                SkillTreeUpgrade.interactable = false;
                SkillTreeUpgardeText.text = "МАКС";
                SkillTreeCostText.text = "МАКС";
            }
        }

        if (id == 8)
        {
            SkillTreeUpgrade.interactable = true;
            SkillTreeUnlock.interactable = false;
            SkillTreeDiscription.text = "Ах золото, такое красивое, блестящее, манящее, кусочек моей прелести";
            SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber8 + "/" + SkilTreeMaxNumber8;
            SkillTreeUpgardeText.text = "...";
            SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost8);
            GoldTextSkillTree.text = "Золото:" + Gold;
            SkillTreeId = 8;
            if (SkillTreeNumber8 == SkilTreeMaxNumber8)
            {
                SkillTreeUpgrade.interactable = false;
                SkillTreeUpgardeText.text = "МАКС";
                SkillTreeCostText.text = "МАКС";
            }
        }

        if (id == 9)
        {
            SkillTreeUpgrade.interactable = true;
            SkillTreeUnlock.interactable = false;
            SkillTreeDiscription.text = "Обычные украшения древних, но тоже самое ли это для обычного банана?";
            SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber9 + "/" + SkilTreeMaxNumber9;
            SkillTreeUpgardeText.text = "...";
            SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost9);
            GoldTextSkillTree.text = "Золото:" + Gold;
            SkillTreeId = 9;
            if (SkillTreeNumber9 == SkilTreeMaxNumber9)
            {
                SkillTreeUpgrade.interactable = false;
                SkillTreeUpgardeText.text = "МАКС";
                SkillTreeCostText.text = "МАКС";
                DarkGoldText.gameObject.SetActive(true);
            }
        }

        if (id == 10)
        {
            SkillTreeUpgrade.interactable = true;
            SkillTreeUnlock.interactable = false;
            SkillTreeDiscription.text = "Здоровье, оно нужно всем, если кончиться, тебе кранты";
            SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber10 + "/" + SkilTreeMaxNumber10;
            SkillTreeUpgardeText.text = "...";
            SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost10);
            GoldTextSkillTree.text = "Золото:" + Gold;
            SkillTreeId = 10;
            if (SkillTreeNumber10 == SkilTreeMaxNumber10)
            {
                SkillTreeUpgrade.interactable = false;
                SkillTreeUpgardeText.text = "МАКС";
                SkillTreeCostText.text = "МАКС";
            }
        }

        if (id == 11)
        {
            SkillTreeUpgrade.interactable = true;
            SkillTreeUnlock.interactable = false;
            SkillTreeDiscription.text = "Урон, бить больнее по голове, ну равзве не прелесть";
            SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber11 + "/" + SkilTreeMaxNumber11;
            SkillTreeUpgardeText.text = "...";
            SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost11);
            GoldTextSkillTree.text = "Золото:" + Gold;
            SkillTreeId = 11;
            if (SkillTreeNumber11 == SkilTreeMaxNumber11)
            {
                SkillTreeUpgrade.interactable = false;
                SkillTreeUpgardeText.text = "МАКС";
                SkillTreeCostText.text = "МАКС";
            }
        }
        UpdateUi();
    }

    public void UnlockTreeSkill(int id)
    {
        if (id == 0)
        {
            SkillTreeUnlock.interactable = true;
            SkillTreeUpgrade.interactable = false;
            SkillTreeDiscription.text = "Малютка банан,чаще всего он спокоен, но если его тронуть, буйство его бесконечных сил проснется. Он начнет добывать тебе очки счета";
            SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber0 + "/" + SkilTreeMaxNumber0;
            SkillTreeUpgardeText.text = "" + ScoreValueTimePlus + " -> " + 1;
            SkillTreeCostText.text = "Стоимость:" + SkillTreeCost;
            GoldTextSkillTree.text = "Золото:" + Gold;
            SkillTreeId = 0;
        }

        if (id == 1)
        {
            SkillTreeUnlock.interactable = true;
            SkillTreeUpgrade.interactable = false;
            SkillTreeDiscription.text = "Приют, бедность, воровство, всё это ему знакомо, он же просто пытается заработать себе на жизнь. Воришка добывает золото";
            SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber1 + "/" + SkilTreeMaxNumber1;
            SkillTreeUpgardeText.text = "" + GoldValueTimePlus + " -> " + 1;
            SkillTreeCostText.text = "Стоимость:" + SkillTreeCost1;
            GoldTextSkillTree.text = "Золото:" + Gold;
            SkillTreeId = 1;
        }

        if (id == 2)
        {
            SkillTreeUnlock.interactable = true;
            SkillTreeUpgrade.interactable = false;
            SkillTreeDiscription.text = "Желторотик и магического колледжа, он умеет только превращать воду в виски и помогать тебе получать опыт";
            SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber2 + "/" + SkilTreeMaxNumber2;
            SkillTreeUpgardeText.text = "" + XpValueTimePlus + " -> " + 1;
            SkillTreeCostText.text = "Стоимость:" + SkillTreeCost2;
            GoldTextSkillTree.text = "Золото:" + Gold;
            SkillTreeId = 2;
        }

        if (id == 3)
        {
            SkillTreeUnlock.interactable = true;
            SkillTreeUpgrade.interactable = false;
            SkillTreeDiscription.text = "Звонкая монета всегда радует глаз, поможет тебе быстрее находить монеты";
            SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber3 + "/" + SkilTreeMaxNumber3;
            SkillTreeUpgardeText.text = "" + GoldChanceSkillTree + "%" + " -> " + 5 + "%";
            SkillTreeCostText.text = "Стоимость:" + SkillTreeCost3;
            GoldTextSkillTree.text = "Золото:" + Gold;
            SkillTreeId = 3;
        }

        if (id == 4)
        {
            SkillTreeUnlock.interactable = true;
            SkillTreeUpgrade.interactable = false;
            SkillTreeDiscription.text = "Одна монета хорошо, но когда их много, гораздо лучше, позвлит увелить находимое количсетво монет";
            SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber4 + "/" + SkilTreeMaxNumber4;
            SkillTreeUpgardeText.text = "" + GoldMultiSkillTree + "X" + " -> " + 1 + "X";
            SkillTreeCostText.text = "Стоимость:" + SkillTreeCost4;
            GoldTextSkillTree.text = "Золото:" + Gold;
            SkillTreeId = 4;
        }

        if (id == 5)
        {
            SkillTreeUnlock.interactable = true;
            SkillTreeUpgrade.interactable = false;
            SkillTreeDiscription.text = "Этот мешочек прсто великолепен, он дарует тебе возможость получать больше опыта за клик";
            SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber5 + "/" + SkilTreeMaxNumber5;
            SkillTreeUpgardeText.text = "" + XpMultiSkillTree + "X" + " -> " + 1 + "X";
            SkillTreeCostText.text = "Стоимость:" + SkillTreeCost5;
            GoldTextSkillTree.text = "Золото:" + Gold;
            SkillTreeId = 5;
        }
    }

    public void UnlockButtonSkillTree()
    {
        if (SkillTreeId == 0)
        {
            if (Gold >= SkillTreeCost)
            {
                Gold -= 500;
                SkillTreeUnlock.interactable = false;
                InvinsibleButtonSkillTreeLock0.gameObject.SetActive(false);
                SkillTreeUpgrade.interactable = true;
                SkillTreeLock0.gameObject.SetActive(false);
                SkillTreeLock1.gameObject.SetActive(false);
                SkillTreeLock5.gameObject.SetActive(false);
                SkillTreeLock9.gameObject.SetActive(false);
                SkillTreeDiscription.text = "Малютка банан,чаще всего он спокоен, но если его тронуть, буйство его бесконечных сил проснется. Он начнет добывать тебе очки счета";
                SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber0 + "/" + SkilTreeMaxNumber0;
                SkillTreeUpgardeText.text = "" + ScoreValueTimePlus + " -> " + 1;
                SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost);
                GoldTextSkillTree.text = "Золото:" + Gold;
            }
            YandexGame.savesData.InvinsibleButtonSkillTreeLock0Save = false;
            YandexGame.savesData.SkillTreeLockSave = false;
            YandexGame.savesData.SkillTreeLockSave1 = false;
            YandexGame.savesData.SkillTreeLockSave5 = false;
            YandexGame.savesData.SkillTreeLockSave9 = false;
        }

        if (SkillTreeId == 1)
        {
            if (Gold >= SkillTreeCost1)
            {
                Gold -= 1000;
                SkillTreeUnlock.interactable = false;
                InvinsibleButtonSkillTreeLock1.gameObject.SetActive(false);
                SkillTreeUpgrade.interactable = true;
                SkillTreeLock2.gameObject.SetActive(false);
                SkillTreeLock3.gameObject.SetActive(false);
                SkillTreeDiscription.text = "Приют, бедность, воровство, всё это ему знакомо, он же просто пытается заработать себе на жизнь. Воришка добывает золото";
                SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber1 + "/" + SkilTreeMaxNumber1;
                SkillTreeUpgardeText.text = "" + GoldValueTimePlus + " -> " + 1;
                SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost1);
                GoldTextSkillTree.text = "Золото:" + Gold;               
            }
            YandexGame.savesData.SkillTreeLockSave2 = false;
            YandexGame.savesData.SkillTreeLockSave3 = false;
            YandexGame.savesData.InvinsibleButtonSkillTreeLock1Save = false;
        }

        if (SkillTreeId == 2)
        {
            if (Gold >= SkillTreeCost2)
            {
                Gold -= 1250;
                SkillTreeUnlock.interactable = false;
                InvinsibleButtonSkillTreeLock2.gameObject.SetActive(false);
                SkillTreeUpgrade.interactable = true;
                SkillTreeLock4.gameObject.SetActive(false);
                SkillTreeDiscription.text = "Желторотик и магического колледжа, он умеет только превращать воду в виски и помогать тебе получать опыт";
                SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber2 + "/" + SkilTreeMaxNumber2;
                SkillTreeUpgardeText.text = "" + XpValueTimePlus + " -> " + 1;
                SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost2);
                GoldTextSkillTree.text = "Золото:" + Gold;
            }
            YandexGame.savesData.SkillTreeLockSave4 = false;
            YandexGame.savesData.InvinsibleButtonSkillTreeLock2Save = false;
        }

        if (SkillTreeId == 3)
        {
            if (Gold >= SkillTreeCost3)
            {
                Gold -= 1250;
                SkillTreeUnlock.interactable = false;
                InvinsibleButtonSkillTreeLock3.gameObject.SetActive(false);
                SkillTreeUpgrade.interactable = true;
                SkillTreeDiscription.text = "Звонкая монета всегда радует глаз, поможет тебе быстрее находить монеты";
                SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber3 + "/" + SkilTreeMaxNumber3;
                SkillTreeUpgardeText.text = "" + GoldChanceSkillTree + "%" + " -> " + 5 + "%";
                SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost3);
                GoldTextSkillTree.text = "Золото:" + Gold;
            }
            YandexGame.savesData.InvinsibleButtonSkillTreeLock3Save = false;
        }

        if (SkillTreeId == 4)
        {
            if (Gold >= SkillTreeCost4)
            {
                Gold -= 1750;
                SkillTreeUnlock.interactable = false;
                InvinsibleButtonSkillTreeLock4.gameObject.SetActive(false);
                SkillTreeUpgrade.interactable = true;
                SkillTreeDiscription.text = "Одна монета хорошо, но когда их много, гораздо лучше, позвлит увелить находимое количсетво монет";
                SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber4 + "/" + SkilTreeMaxNumber4;
                SkillTreeUpgardeText.text = "" + GoldMultiSkillTree + "X" + " -> " + 1 + "X";
                SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost4);
                GoldTextSkillTree.text = "Золото:" + Gold;
            }
            YandexGame.savesData.InvinsibleButtonSkillTreeLock4Save = false;
        }

        if (SkillTreeId == 5)
        {
            if (Gold >= SkillTreeCost5)
            {
                Gold -= 1500;
                SkillTreeUnlock.interactable = false;
                InvinsibleButtonSkillTreeLock5.gameObject.SetActive(false);
                SkillTreeUpgrade.interactable = true;
                SkillTreeDiscription.text = "Этот мешочек прсто великолепен, он дарует тебе возможость получать больше опыта за клик";
                SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber5 + "/" + SkilTreeMaxNumber5;
                SkillTreeUpgardeText.text = "" + XpMultiSkillTree + "X" + " -> " + 1 + "X";
                SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost5);
                GoldTextSkillTree.text = "Золото:" + Gold;
            }
            YandexGame.savesData.InvinsibleButtonSkillTreeLock5Save = false;
        }
        YandexGame.SaveProgress();
    }

    public void SkillTreeUpgradeButton()
    {
        if (SkillTreeId == 0)
        {
            if (Gold >= SkillTreeCost)
            {
                Gold -= SkillTreeCost;
                SkillTreeNumber0 += 1;
                ScoreValueTimePlus += 1;
                SkillTreeCost += 50;
                SkillTreeDiscription.text = "Малютка банан,чаще всего он спокоен, но если его тронуть, буйство его бесконечных сил проснется. Он начнет добывать тебе очки счета";
                SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber0 + "/" + SkilTreeMaxNumber0;
                SkillTreeUpgardeText.text = "" + ScoreValueTimePlus + " -> " + (ScoreValueTimePlus + 1);
                SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost);
                GoldTextSkillTree.text = "Золото:" + Gold;
            }
            if (SkillTreeNumber0 == SkilTreeMaxNumber0)
            {
                SkillTreeUpgrade.interactable = false;
                SkillTreeUpgardeText.text = "МАКС";
                SkillTreeCostText.text = "МАКС";
            }
        }

        if (SkillTreeId == 1)
        {
            if (Gold >= SkillTreeCost1)
            {
                Gold -= SkillTreeCost1;
                SkillTreeNumber1 += 1;
                GoldValueTimePlus += 1;
                SkillTreeCost1 += 100;
                SkillTreeDiscription.text = "Приют, бедность, воровство, всё это ему знакомо, он же просто пытается заработать себе на жизнь. Воришка добывает золото";
                SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber1 + "/" + SkilTreeMaxNumber1;
                SkillTreeUpgardeText.text = "" + GoldValueTimePlus + " -> " + (GoldValueTimePlus + 1);
                SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost1);
                GoldTextSkillTree.text = "Золото:" + Gold;
            }
            if (SkillTreeNumber1 == SkilTreeMaxNumber1)
            {
                SkillTreeUpgrade.interactable = false;
                SkillTreeUpgardeText.text = "МАКС";
                SkillTreeCostText.text = "МАКС";
            }
        }

        if (SkillTreeId == 2)
        {
            if (Gold >= SkillTreeCost2)
            {
                Gold -= SkillTreeCost2;
                SkillTreeNumber2 += 1;
                XpValueTimePlus += 1;
                SkillTreeCost2 += 250;
                SkillTreeDiscription.text = "Желторотик и магического колледжа, он умеет только превращать воду в виски и помогать тебе получать опыт";
                SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber2 + "/" + SkilTreeMaxNumber2;
                SkillTreeUpgardeText.text = "" + XpValueTimePlus + " -> " + (XpValueTimePlus + 1);
                SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost2);
                GoldTextSkillTree.text = "Золото:" + Gold;
            }
            if (SkillTreeNumber2 == SkilTreeMaxNumber2)
            {
                SkillTreeUpgrade.interactable = false;
                SkillTreeUpgardeText.text = "МАКС";
                SkillTreeCostText.text = "МАКС";
            }
        }

        if (SkillTreeId == 3)
        {
            if (Gold >= SkillTreeCost3)
            {
                Gold -= SkillTreeCost3;
                SkillTreeNumber3 += 1;
                GoldChanceSkillTree += 5;
                SkillTreeCost3 += 250;
                SkillTreeDiscription.text = "Звонкая монета всегда радует глаз, поможет тебе быстрее находить монеты";
                SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber3 + "/" + SkilTreeMaxNumber3;
                SkillTreeUpgardeText.text = "" + GoldChanceSkillTree + "%" + " -> " + (GoldChanceSkillTree + 5) + "%";
                SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost3);
                GoldTextSkillTree.text = "Золото:" + Gold;
            }
            if (SkillTreeNumber3 == SkilTreeMaxNumber3)
            {
                SkillTreeUpgrade.interactable = false;
                SkillTreeUpgardeText.text = "МАКС";
                SkillTreeCostText.text = "МАКС";
            }
        }

        if (SkillTreeId == 4)
        {
            if (Gold >= SkillTreeCost4)
            {
                Gold -= SkillTreeCost4;
                SkillTreeNumber4 += 1;
                GoldMultiSkillTree += 1;
                SkillTreeCost4 += 150;
                SkillTreeDiscription.text = "Одна монета хорошо, но когда их много, гораздо лучше, позвлит увелить находимое количсетво монет";
                SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber4 + "/" + SkilTreeMaxNumber4;
                SkillTreeUpgardeText.text = "" + GoldMultiSkillTree + "X" + " -> " + (GoldMultiSkillTree + 1) + "X";
                SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost4);
                GoldTextSkillTree.text = "Золото:" + Gold;
            }
            if (SkillTreeNumber4 == SkilTreeMaxNumber4)
            {
                SkillTreeUpgrade.interactable = false;
                SkillTreeUpgardeText.text = "МАКС";
                SkillTreeCostText.text = "МАКС";
            }
        }

        if (SkillTreeId == 5)
        {
            if (Gold >= SkillTreeCost5)
            {
                Gold -= SkillTreeCost5;
                SkillTreeNumber5 += 1;
                XpMultiSkillTree += 1;
                SkillTreeCost5 += 100;
                SkillTreeDiscription.text = "Этот мешочек прсто великолепен, он дарует тебе возможость получать больше опыта за клик";
                SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber5 + "/" + SkilTreeMaxNumber5;
                SkillTreeUpgardeText.text = "" + XpMultiSkillTree + "X" + " -> " + (XpMultiSkillTree + 1) + "X";
                SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost5);
                GoldTextSkillTree.text = "Золото:" + Gold;
            }
            if (SkillTreeNumber5 == SkilTreeMaxNumber5)
            {
                SkillTreeUpgrade.interactable = false;
                SkillTreeUpgardeText.text = "МАКС";
                SkillTreeCostText.text = "МАКС";
            }
        }

        if (SkillTreeId == 6)
        {
            if (Gold >= SkillTreeCost6)
            {
                Gold -= SkillTreeCost6;
                SkillTreeNumber6 += 1;
                SkillTreeDiscription.text = "Заброшенная потомками шахта, но какие-то ресурсы там точно есть";
                SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber6 + "/" + SkilTreeMaxNumber6;
                SkillTreeUpgardeText.text = "...";
                SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost6);
                GoldTextSkillTree.text = "Золото:" + Gold;
            }
            if (SkillTreeNumber6 == SkilTreeMaxNumber6)
            {
                SkillTreeUpgrade.interactable = false;
                SkillTreeUpgardeText.text = "МАКС";
                SkillTreeCostText.text = "МАКС";
                SkillTreeLock6.gameObject.SetActive(false);
                YandexGame.savesData.SkillTreeLockSave6 = false;
                SkillTreeLock8.gameObject.SetActive(false);
                YandexGame.savesData.SkillTreeLockSave8 = false;
            }
            MenuCaveButton.interactable = true;
        }

        if (SkillTreeId == 7)
        {
            if (Gold >= SkillTreeCost7)
            {
                Gold -= SkillTreeCost7;
                SkillTreeNumber7 += 1;
                SkillTreeDiscription.text = "Медь, хороший метериал для разных вещей";
                SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber7 + "/" + SkilTreeMaxNumber7;
                SkillTreeUpgardeText.text = "...";
                SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost7);
                GoldTextSkillTree.text = "Золото:" + Gold;
            }
            if (SkillTreeNumber7 == SkilTreeMaxNumber7)
            {
                SkillTreeUpgrade.interactable = false;
                SkillTreeUpgardeText.text = "МАКС";
                SkillTreeCostText.text = "МАКС";
                SkillTreeLock7.gameObject.SetActive(false);
                YandexGame.savesData.SkillTreeLockSave7 = false;
            }
        }

        if (SkillTreeId == 8)
        {
            if (Gold >= SkillTreeCost8)
            {
                Gold -= SkillTreeCost8;
                SkillTreeNumber8 += 1;
                SkillTreeDiscription.text = "Ах золото, такое красивое, блестящее, манящее, кусочек моей прелести";
                SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber8 + "/" + SkilTreeMaxNumber8;
                SkillTreeUpgardeText.text = "...";
                SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost8);
                GoldTextSkillTree.text = "Золото:" + Gold;
            }
            if (SkillTreeNumber8 == SkilTreeMaxNumber8)
            {
                SkillTreeUpgrade.interactable = false;
                SkillTreeUpgardeText.text = "МАКС";
                SkillTreeCostText.text = "МАКС";
                GoldButton.interactable = true;
            }
        }

        if (SkillTreeId == 9)
        {
            if (Gold >= SkillTreeCost9)
            {
                Gold -= SkillTreeCost9;
                SkillTreeNumber9 += 1;
                DarkGoldChance += 1;
                SkillTreeDiscription.text = "Обычные украшения древних, но тоже самое ли это для обычного банана?";
                SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber9 + "/" + SkilTreeMaxNumber9;
                SkillTreeUpgardeText.text = "...";
                SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost9);
                GoldTextSkillTree.text = "Золото:" + Gold;
            }
            if (SkillTreeNumber9 == SkilTreeMaxNumber9)
            {
                SkillTreeUpgrade.interactable = false;
                SkillTreeUpgardeText.text = "МАКС";
                SkillTreeCostText.text = "МАКС";
                DarkGoldText.gameObject.SetActive(true);
            }
        }

        if (SkillTreeId == 10)
        {
            if (Gold >= SkillTreeCost10)
            {
                Gold -= SkillTreeCost10;
                SkillTreeNumber10 += 1;
                SkillTreeCost10 += 250;
                PlayerMaxHp += 2;
                SkillTreeDiscription.text = "Здоровье, оно нужно всем, если кончиться, тебе кранты";
                SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber10 + "/" + SkilTreeMaxNumber10;
                SkillTreeUpgardeText.text = "...";
                SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost10);
                GoldTextSkillTree.text = "Золото:" + Gold;
                SkillTreeLock10.gameObject.SetActive(false);
            }
            if (SkillTreeNumber10 == SkilTreeMaxNumber10)
            {
                SkillTreeUpgrade.interactable = false;
                SkillTreeUpgardeText.text = "МАКС";
                SkillTreeCostText.text = "МАКС";
            }
            YandexGame.savesData.SkillTreeLockSave10 = false;
        }

        if (SkillTreeId == 11)
        {
            if (Gold >= SkillTreeCost11)
            {
                Gold -= SkillTreeCost11;
                SkillTreeNumber11 += 1;
                SkillTreeCost11 += 150;
                PlayerDamage += PlayerDamageTapPlus;
                PlayerDamageTap += PlayerDamageTapPlus;
                SkillTreeDiscription.text = "Урон, бить больнее по голове, ну равзве не прелесть";
                SkillTreeUpgradeDiscription.text = "" + SkillTreeNumber11 + "/" + SkilTreeMaxNumber11;
                SkillTreeUpgardeText.text = "...";
                SkillTreeCostText.text = "Стоимость:" + (SkillTreeCost11);
                GoldTextSkillTree.text = "Золото:" + Gold;
            }
            if (SkillTreeNumber11 == SkilTreeMaxNumber11)
            {
                SkillTreeUpgrade.interactable = false;
                SkillTreeUpgardeText.text = "МАКС";
                SkillTreeCostText.text = "МАКС";
            }
        }
        UpdateUi();
        YandexGame.SaveProgress();
    }

    //!!!!!!!!!!!!!!!!! Меню Руды !!!!!!!!!!!!!!!!!!!!!! 

    IEnumerator OreTimer()
    {
        while (true) // Бесконечный цикл
        {
            yield return new WaitForSeconds(1);
            OreIronTimeSlider();
            OreCopperTimeSlider();
            OreGoldTimeSlider();
            EnemyAttackTime();
            PlayerAttackTime();
            EnemyHpText.text = EnemyHp + "|" + EnemyMaxHp;
            PlayerHpText.text = PLayerHp + "|" + PlayerMaxHp;
        }
    }

    public void OreFurnace()
    {
        IngotIron += OreIron / 2;
        OreIron = OreIron % 2;

        IngotCopper += OreCopper / 2;
        OreCopper = OreCopper % 2;

        IngotGold += OreGold / 3;
        OreGold = OreGold % 2;

        AmountIngotIronText.text = "" + IngotIron;
        AmountIngotCopperText.text = "" + IngotCopper;
        AmountIngotGoldText.text = "" + IngotGold;

        OreIronAmountText.text = "" + OreIron;
        OreCopperAmountText.text = "" + OreCopper;
        OreGoldAmountText.text = "" + OreGold;
    }

    public void OreIronSlider()
    {
        IronSlider.maxValue = OreIronTime;
        IronSlider.value = OreIronTimeZero;
    }

    public void OreIronTimeSlider()
    {
        OreIronSlider();
        OreIronTimeZero += 1f;
        int OreIronRandom = Random.Range(1, 2);
        if (OreIronTimeZero == OreIronTime)
        {
            OreIron += OreIronRandom * OreIronUpgrade;
            OreIronTimeZero = 0f;
            OreIronAmountText.text = "" + OreIron;
        }
    }

    public void OreCoppernSlider()
    {
        CopperSlider.maxValue = OreCopperTime;
        CopperSlider.value = OreCopperTimeZero;
    }

    public void OreCopperTimeSlider()
    {
        if (CopperButton.interactable == true)
        {
            OreCoppernSlider();
            OreCopperTimeZero += 1f;
            int OreCopperRandom = Random.Range(1, 2);
            if (OreCopperTimeZero == OreCopperTime)
            {
                OreCopper += OreCopperRandom * OreCopperUpgrade;
                OreCopperTimeZero = 0f;
                OreCopperAmountText.text = "" + OreCopper;
            }
        }
    }

    public void OreGoldSlider()
    {
        GoldSlider.maxValue = OreGoldTime;
        GoldSlider.value = OreGoldTimeZero;
    }

    public void OreGoldTimeSlider()
    {
        if (GoldButton.interactable == true)
        {
            OreGoldSlider();
            OreGoldTimeZero += 1f;
            int OreGoldRandom = Random.Range(1, 2);
            if (OreGoldTimeZero == OreGoldTime)
            {
                OreGold += OreGoldRandom * OreGoldUpgrade;
                OreGoldTimeZero = 0f;
                OreGoldAmountText.text = "" + OreGold;
            }
        }
    }

    public void OreIronButton()
    {
        OreId = 0;
        OreUpgradeButton.interactable = true;
        OreNameText.text = "Железная Руда";
        OreTimeDiscriptionText.text = "" + OreIronTime + " сек";
        OreCostText.text = "" + Gold + " / " + OreIronCostUpgrade;
        OreUpgradeDiscriptionTimeText.text = "" + OreIronTime + " -> " + (OreIronTime - 1f);
        OreUpUpgradeText.text = "" + OreIronUpgrade + "X" + " -> " + (OreIronUpgrade + 1) + "X";
        OreNumberUpgradeText.text = "" + OreIronNumber + " / " + OreIronMaxNumber;
        if (OreIronNumber == OreIronMaxNumber)
        {
            OreUpgradeButton.interactable = false;
            OreNumberUpgradeText.text = "МАКС";
            OreCostText.text = "МАКС";
            OreUpUpgradeText.text = "МАКС";
            OreUpgradeDiscriptionTimeText.text = "МАКС";
        }
    }

    public void OreCopperButton()
    {
        OreId = 1;
        OreUpgradeButton.interactable = true;
        OreNameText.text = "Медная Руда";
        OreTimeDiscriptionText.text = "" + OreCopperTime + " сек";
        OreCostText.text = "" + Gold + " / " + OreCopperCostUpgrade;
        OreUpgradeDiscriptionTimeText.text = "" + OreCopperTime + " -> " + (OreCopperTime - 1f);
        OreUpUpgradeText.text = "" + OreCopperUpgrade + "X" + " -> " + (OreCopperUpgrade + 1) + "X";
        OreNumberUpgradeText.text = "" + OreCopperNumber + " / " + OreCopperMaxNumber;
        if (OreCopperNumber == OreCopperMaxNumber)
        {
            OreUpgradeButton.interactable = false;
            OreNumberUpgradeText.text = "МАКС";
            OreCostText.text = "МАКС";
            OreUpUpgradeText.text = "МАКС";
            OreUpgradeDiscriptionTimeText.text = "МАКС";
        }
    }

    public void OreGoldButton()
    {
        OreId = 2;
        OreUpgradeButton.interactable = true;
        OreNameText.text = "Золотая Руда";
        OreTimeDiscriptionText.text = "" + OreGoldTime + " сек";
        OreCostText.text = "" + Gold + " / " + OreGoldCostUpgrade;
        OreUpgradeDiscriptionTimeText.text = "" + OreGoldTime + " -> " + (OreGoldTime - 1f);
        OreUpUpgradeText.text = "" + OreGoldUpgrade + "X" + " -> " + (OreGoldUpgrade + 1) + "X";
        OreNumberUpgradeText.text = "" + OreGoldNumber + " / " + OreGoldMaxNumber;
        if (OreGoldNumber == OreGoldMaxNumber)
        {
            OreUpgradeButton.interactable = false;
            OreNumberUpgradeText.text = "МАКС";
            OreCostText.text = "МАКС";
            OreUpUpgradeText.text = "МАКС";
            OreUpgradeDiscriptionTimeText.text = "МАКС";
        }
    }

    public void OreUpgrade()
    {
        if (OreId == 0)
        {
            if (Gold >= OreIronCostUpgrade)
            {
                Gold -= OreIronCostUpgrade;
                OreIronCostUpgrade += 1000;
                OreIronNumber += 1;
                OreIronTime -= 1f;
                OreIronUpgrade += 1;
                OreCostText.text = "" + Gold + " / " + OreIronCostUpgrade;
                OreNumberUpgradeText.text = "" + OreIronNumber + " / " + OreIronMaxNumber;
                OreTimeDiscriptionText.text = "" + OreIronTime + " сек";
                OreUpUpgradeText.text = "" + OreIronUpgrade + "X" + " -> " + (OreIronUpgrade + 1) + "X";
                OreUpgradeDiscriptionTimeText.text = "" + OreIronTime + " -> " + (OreIronTime - 1f);
            }
            if (OreIronNumber == OreIronMaxNumber)
            {
                OreUpgradeButton.interactable = false;
                OreNumberUpgradeText.text = "МАКС";
                OreCostText.text = "МАКС";
                OreUpUpgradeText.text = "МАКС";
                OreUpgradeDiscriptionTimeText.text = "МАКС";
            }
            YandexGame.savesData.GoldSave = Gold;
            YandexGame.savesData.OreIronNumberSave = OreIronNumber;
            YandexGame.savesData.OreIronTimeSave = OreIronTime;
            YandexGame.savesData.OreIronUpgradeSave = OreIronUpgrade;
            YandexGame.savesData.OreIronCostUpgradeSave = OreIronCostUpgrade;
            YandexGame.SaveProgress();
        }

        if (OreId == 1)
        {
            if (Gold >= OreCopperCostUpgrade)
            {
                Gold -= OreCopperCostUpgrade;
                OreCopperCostUpgrade += 1500;
                OreCopperNumber += 1;
                OreCopperTime -= 1f;
                OreCopperUpgrade += 1;
                OreCostText.text = "" + Gold + " / " + OreCopperCostUpgrade;
                OreNumberUpgradeText.text = "" + OreCopperNumber + " / " + OreCopperMaxNumber;
                OreTimeDiscriptionText.text = "" + OreCopperTime + " сек";
                OreUpUpgradeText.text = "" + OreCopperUpgrade + "X" + " -> " + (OreCopperUpgrade + 1) + "X";
                OreUpgradeDiscriptionTimeText.text = "" + OreCopperTime + " -> " + (OreCopperTime - 1f);
            }
            if (OreCopperNumber == OreCopperMaxNumber)
            {
                OreUpgradeButton.interactable = false;
                OreNumberUpgradeText.text = "МАКС";
                OreCostText.text = "МАКС";
                OreUpUpgradeText.text = "МАКС";
                OreUpgradeDiscriptionTimeText.text = "МАКС";
            }
        }

        if (OreId == 2)
        {
            if (Gold >= OreGoldCostUpgrade)
            {
                Gold -= OreGoldCostUpgrade;
                OreGoldCostUpgrade += 3000;
                OreGoldNumber += 1;
                OreGoldTime -= 1f;
                OreGoldUpgrade += 1;
                OreCostText.text = "" + Gold + " / " + OreGoldCostUpgrade;
                OreNumberUpgradeText.text = "" + OreGoldNumber + " / " + OreGoldMaxNumber;
                OreTimeDiscriptionText.text = "" + OreGoldTime + " сек";
                OreUpUpgradeText.text = "" + OreGoldUpgrade + "X" + " -> " + (OreGoldUpgrade + 1) + "X";
                OreUpgradeDiscriptionTimeText.text = "" + OreGoldTime + " -> " + (OreGoldTime - 1f);
            }
            if (OreGoldNumber == OreGoldMaxNumber)
            {
                OreUpgradeButton.interactable = false;
                OreNumberUpgradeText.text = "МАКС";
                OreCostText.text = "МАКС";
                OreUpUpgradeText.text = "МАКС";
                OreUpgradeDiscriptionTimeText.text = "МАКС";
            }
        }
    }

    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!Artifact Upgarde!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!//

    public void ArtifactUpgarde(int id)
    {
        if (id == 0)
        {
            ArtifId = 0;
            MetallUpgradeImage.sprite = MettallSpriteImage[ArtifId];
            ArtifNameText.text = "Меч Людвига";
            ArtifHpUpText.text = "+" + ArtifactHp0;
            ArtifDamageUpText.text = "+" + ArtifactDamage0;
            ArtifCriticalChanceUpText.text = "+" + ArtifactCriticalDamageChance0;
            ArtifDamageTimeUpText.text = "+" + ArtifactDamageTime0;
            ArtifDamageTapText.text = "+" + ArtifactDamageTap0;

            upgardeNumber.text = ArtifactUpgradeNumber0 + "|" + ArtifactUpgradeNumberMax0;

            UpgardeDiscriptionText.text = "Стоимость улучшения";
            GoldArtifUpgradeText.text = Gold + "/" + ArtifactGoldCost0;
            DarkGoldArtifUpgradeText.text = DarkGold + "/" + ArtifactDarkGoldCost0;
            ScoreArtifUpgradeText.text = Score + "/" + ArtifactScoreCost0;
            MetallArtifUpgradeText.text = IngotIron + "/" + ArtifactIronCost0;

            ArtifactButtonUpgarde.interactable = true;
        }

        if (id == 1)
        {
            ArtifId = 1;
            MetallUpgradeImage.sprite = MettallSpriteImage[ArtifId];
            ArtifNameText.text = "Грибочек любви";
            ArtifHpUpText.text = "+" + ArtifactHp1;
            ArtifDamageUpText.text = "...";
            ArtifCriticalChanceUpText.text = "...";
            ArtifDamageTimeUpText.text = "...";
            ArtifDamageTapText.text = "...";

            upgardeNumber.text = ArtifactUpgradeNumber1 + "|" + ArtifactUpgradeNumberMax1;

            UpgardeDiscriptionText.text = "Стоимость улучшения";
            GoldArtifUpgradeText.text = Gold + "/" + ArtifactGoldCost1;
            DarkGoldArtifUpgradeText.text = DarkGold + "/" + ArtifactDarkGoldCost1;
            ScoreArtifUpgradeText.text = Score + "/" + ArtifactScoreCost1;
            MetallArtifUpgradeText.text = IngotCopper + "/" + ArtifactCopperCost1;

            ArtifactButtonUpgarde.interactable = true;
        }
    }

    public void ArtifactUogardeButton()
    {
        if (ArtifId == 0)
        {
            if (Gold >= ArtifactGoldCost0 & DarkGold >= ArtifactDarkGoldCost0 & Score >= ArtifactScoreCost0 & IngotIron >= ArtifactIronCost0)
            {
                Gold -= ArtifactGoldCost0;
                DarkGold -= ArtifactDarkGoldCost0;
                Score -= ArtifactScoreCost0;
                IngotIron -= ArtifactIronCost0;

                PlayerMaxHp += ArtifactHp0;
                PlayerDamage += ArtifactDamage0;
                PlayerDamageTap += ArtifactDamageTap0;
                PlayerCriticalDamageChance += ArtifactCriticalDamageChance0;
                PlayerDamageTime -= ArtifactDamageTime0;

                ArtifactUpgradeNumber0 += 1;

                ArtifactGoldCost0 += 5000;
                ArtifactDarkGoldCost0 += 2;
                ArtifactScoreCost0 += 30000;
                ArtifactIronCost0 += 150;

                PlayerStatText.text = "Характеристики";
                PlayerStatHpText.text = PlayerMaxHp + ":";
                PlayerStatDamageText.text = PlayerDamage + ":";
                PlayerStatDamageTapText.text = PlayerDamageTap + ":";
                PlayerStatChanceDamageText.text = PlayerCriticalDamageChance + ":";
                PlayerStatDamageTimeText.text = PlayerDamageTime + ":";

                upgardeNumber.text = ArtifactUpgradeNumber0 + "|" + ArtifactUpgradeNumberMax0;

                UpgardeDiscriptionText.text = "Стоимость улучшения";
                GoldArtifUpgradeText.text = Gold + "/" + ArtifactGoldCost0;
                DarkGoldArtifUpgradeText.text = DarkGold + "/" + ArtifactDarkGoldCost0;
                ScoreArtifUpgradeText.text = Score + "/" + ArtifactScoreCost0;
                MetallArtifUpgradeText.text = IngotIron + "/" + ArtifactIronCost0;
            }

            if (ArtifactUpgradeNumber0 == ArtifactUpgradeNumberMax0)
            {
                ArtifNameText.text = "Меч Людвига";
                ArtifHpUpText.text = "МАКС";
                ArtifDamageUpText.text = "МАКС";
                ArtifCriticalChanceUpText.text = "МАКС";
                ArtifDamageTimeUpText.text = "МАКС";
                ArtifDamageTapText.text = "МАКС";

                UpgardeDiscriptionText.text = "Стоимость улучшения";
                GoldArtifUpgradeText.text = "МАКС";
                DarkGoldArtifUpgradeText.text = "МАКС";
                ScoreArtifUpgradeText.text = "МАКС";
                MetallArtifUpgradeText.text = "МАКС";
            }
        }

        if (ArtifId == 1)
        {
            if (Gold >= ArtifactGoldCost1 & DarkGold >= ArtifactDarkGoldCost1 & Score >= ArtifactScoreCost1 & IngotCopper >= ArtifactCopperCost1)
            {
                Gold -= ArtifactGoldCost1;
                DarkGold -= ArtifactDarkGoldCost1;
                Score -= ArtifactScoreCost1;
                IngotCopper -= ArtifactCopperCost1;

                PlayerMaxHp += ArtifactHp1;

                ArtifactUpgradeNumber1 += 1;

                ArtifactGoldCost0 += 5000;
                ArtifactDarkGoldCost0 += 2;
                ArtifactScoreCost0 += 30000;
                ArtifactCopperCost1 += 150;

                PlayerStatText.text = "Характеристики";
                PlayerStatHpText.text = PlayerMaxHp + ":";
                PlayerStatDamageText.text = PlayerDamage + ":";
                PlayerStatDamageTapText.text = PlayerDamageTap + ":";
                PlayerStatChanceDamageText.text = PlayerCriticalDamageChance + ":";
                PlayerStatDamageTimeText.text = PlayerDamageTime + ":";

                upgardeNumber.text = ArtifactUpgradeNumber1 + "|" + ArtifactUpgradeNumberMax1;

                UpgardeDiscriptionText.text = "Стоимость улучшения";
                GoldArtifUpgradeText.text = Gold + "/" + ArtifactGoldCost1;
                DarkGoldArtifUpgradeText.text = DarkGold + "/" + ArtifactDarkGoldCost1;
                ScoreArtifUpgradeText.text = Score + "/" + ArtifactScoreCost1;
                MetallArtifUpgradeText.text = IngotCopper + "/" + ArtifactCopperCost1;
            }

            if (ArtifactUpgradeNumber1 == ArtifactUpgradeNumberMax1)
            {
                ArtifNameText.text = "Грибочек любви";
                ArtifHpUpText.text = "МАКС";
                ArtifDamageUpText.text = "МАКС";
                ArtifCriticalChanceUpText.text = "МАКС";
                ArtifDamageTimeUpText.text = "МАКС";
                ArtifDamageTapText.text = "МАКС";

                UpgardeDiscriptionText.text = "Стоимость улучшения";
                GoldArtifUpgradeText.text = "МАКС";
                DarkGoldArtifUpgradeText.text = "МАКС";
                ScoreArtifUpgradeText.text = "МАКС";
                MetallArtifUpgradeText.text = "МАКС";
            }
        }
    }

    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!Arena Menu!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!//

    public void UpdateHpSlider()
    {
        PlayerHpSlider.maxValue = PlayerMaxHp;
        PlayerHpSlider.value = PLayerHp;
    }

    public void UpdateEnemyHpSlider()
    {
        EnemyHpSlider.maxValue = EnemyMaxHp;
        EnemyHpSlider.value = EnemyHp;
    }

    public void EnemyAttackTime()
    {
        PlayerEnemyDamageTime += 1;
        if (PlayerEnemyDamageTime >= PlayerDamageTime)
        {
            PlayerEnemyDamageTime = 0;
            EnemyHp -= PlayerDamage;
            UpdateEnemyHpSlider();
            EnemyHpText.text = EnemyHp + "|" + EnemyMaxHp;
            if (EnemyHp <= 0)
            {
                int Random1ArtifactChance = Random.Range(1, 1000);
                if (Random1ArtifactChance <= 5 * Wave)
                {
                    Artifact1.interactable = true;
                    CheckUnlockArtefact1 = 1;
                }
                UpdateEnemyHpSlider();
                EnemySpriteRandom();
                EnemyKills += 1;
                RewardDieEnemy();
                EnemyHp = EnemyMaxHp;
                EnemyHpText.text = EnemyHp + "|" + EnemyMaxHp;
                EnemyKillsArenaTExt.text = "" + EnemyKills;
                if (EnemyKills == 10)
                {
                    EnemyKills = 0;
                    Wave += 1;
                    EnemyMaxHp += 5;
                    EnemyDamage += 2;
                    EnemyCriticalDamageChance += 1;
                    WaveArenaText.text = "Волна:" + Wave;
                    EnemyKillsArenaTExt.text = "" + EnemyKills;
                }
            }
        }
    }

    public void PlayerAttackTime()
    {
        EnemyDamageTimeZero += 1;
        UpdateEnemyTimerSlider();
        if (EnemyDamageTime == EnemyDamageTimeZero)
        {
            EnemyDamageTimeZero = 0;
            PLayerHp -= EnemyDamage;
            UpdateHpSlider();
            PlayerHpText.text = PLayerHp + "|" + PlayerMaxHp;
            if (PLayerHp <= 0)
            {
                PLayerHp = PlayerMaxHp;
                //EnemySpriteRandom();
                UpdateHpSlider();
                Wave = 1;
                EnemyKills = 0;
                EnemyMaxHp = 20;
                EnemyDamage = 5;
                EnemyCriticalDamageChance = 1;
                WaveArenaText.text = "Волна:" + Wave;
                EnemyKillsArenaTExt.text = "" + EnemyKills;

            }
        }
    }

    public void EnemySpriteRandom()
    {
        int RandomEnemySkinId = Random.Range(0, 7);
        EnemyImageButton.sprite = EnemyRandomSkin[RandomEnemySkinId];
    }

    public void UpdateEnemyTimerSlider()
    {
        EnemyTimeSlider.maxValue = EnemyDamageTime;
        EnemyTimeSlider.value = EnemyDamageTimeZero;
    }

    public void EnemyAttack()
    {
        EnemyHp -= PlayerDamageTap;
        UpdateEnemyHpSlider();
        EnemyHpText.text = EnemyHp + "|" + EnemyMaxHp;
        if (EnemyHp <= 0)
        {
            int Random1ArtifactChance = Random.Range(1, 1000);
            if (Random1ArtifactChance <= 5 * Wave)
            {
                Artifact1.interactable = true;
                CheckUnlockArtefact1 = 1;
            }
            UpdateEnemyHpSlider();
            EnemySpriteRandom();
            EnemyKills += 1;
            RewardDieEnemy();
            EnemyHp = EnemyMaxHp;
            EnemyKillsArenaTExt.text = "" + EnemyKills;
            if (EnemyKills == 10)
            {
                EnemyKills = 0;
                Wave += 1;
                EnemyMaxHp += 5 * Wave;
                EnemyDamage += 2 * Wave;
                EnemyCriticalDamageChance += 1 * Wave;
                WaveArenaText.text = "Волна:" + Wave;
                EnemyKillsArenaTExt.text = "" + EnemyKills;
            }
        }
    }

    public void RewardDieEnemy()
    {
            int RewardRandomGold = Random.Range(0, 5);
            int RewardRandomScore = Random.Range(0, 30);
            int RewardRandomXp = Random.Range(0, 15);
            Gold += RewardRandomGold * Wave;
            Score += RewardRandomScore * Wave;
            LvlXp += RewardRandomXp * Wave;
            GoldAreanText.text = ":" + Gold;
            XpArenaText.text = ":" + LvlXp;
            ScoreArenaText.text = ":" + Score;
    }

    public void ScoreUp()
    {
        int RandomScoreMultiChance = Random.Range(1, 100);
        if (RandomScoreMultiChance <= ScoreMultiChance)
        {
            Score += ScoreClickMulti * ScoreMulti;
        }
        else
        {
            Score += ScoreClickMulti;
        }

        int RandomDarkGoldChance = Random.Range(1, 1000);
        if (RandomDarkGoldChance <= DarkGoldChance * ScoreClickMulti * ScoreMulti)
        {
            DarkGold += 1;
        }

        int Random0ArtifactChance = Random.Range(1, 10000);
        if (RandomDarkGoldChance <= DarkGoldChance * ScoreClickMulti * ScoreMulti)
        {
            Artifact0.interactable = true;
            CheckUnlockArtefact0 = 1;
        }

        if (MaxScore < Score)
        {
            MaxScore = Score;
        }
        int RandomNumber = Random.Range(1, 100);      
        if (RandomNumber <= GoldChance + GoldChanceSkillTree)
        {
            Gold += 1 + GoldMultiSkillTree;
        }
        UpdateUi();
        LevelUp();
    }

    IEnumerator IncrementOverTime()
    {
        while (true) // Бесконечный цикл
        {
            AutoSaveGame();
            yield return new WaitForSeconds(1);
            Score += ScoreValueTimePlus;
            Gold += GoldValueTimePlus;
            LvlXp += XpValueTimePlus;
            ScoreBananaText.text = "" + Score;
            GoldText.text = Gold + ":";
            XpText.text = LvlXp + "/" + LvlMaxXp;
            LevelText.text = "Уровень:" + Level;
            if (LvlXp >= LvlMaxXp)
            {
                LvlXp = LvlXp - LvlMaxXp;
                Level += 1;
                LevelPoint += 1;
                LvlMaxXp *= 2;
            }
            UpdateXpSlider();
        }
    }

    public void LevelUp()
    {
        int RandomLvlNumber = Random.Range(0, 100);
        if (RandomLvlNumber <= LvlChance + XpMultiChance)
        {
            LvlXp += Random.Range(1, 10) * XpMulti * XpMultiSkillTree;
        }
        if (LvlXp >= LvlMaxXp)
        {
            LvlXp = LvlXp - LvlMaxXp;
            Level += 1;
            LevelPoint += 1;
            LvlMaxXp += Mathf.Ceil(LvlMaxXp / 2);
        }
        LevelText.text = "Уровень:" + Level;
        XpText.text = LvlXp + "/" + LvlMaxXp;
        UpdateXpSlider();
    }

    public void UpdateUi()
    {
        ScoreBananaText.text = "" + Score;
        GoldText.text = Gold + ":";
        DarkGoldTextMain.text = DarkGold + ":";
        ScoreBarText.text = "Счет:" + Score;
        GoldBarText.text = "Золото:" + Gold;
        LevelPointBarText.text = "Очки Опыта:" + LevelPoint;
        LevelText.text = "Уровень:" + Level;
        XpText.text = LvlXp + "/" + LvlMaxXp;
        UpdateXpSlider();
        if (MaxScore >= 10)
        {
            MainMenuButton.interactable = true;
        }
        else 
        {
            MainMenuButton.interactable = false;
        }

        if (SkillNumber5 == MaxSkill5Number)
        {
            ChildButtonMenu.interactable = true;
        }
        else
        {
            ChildButtonMenu.interactable= false;
        }

        if (SkillTreeNumber6 == SkilTreeMaxNumber6)
        {
            MenuCaveButton.interactable = true;
        }
        else
        {
            MenuCaveButton.interactable = false;
        }

        if (SkillTreeNumber7 == SkilTreeMaxNumber7)
        {
            CopperButton.interactable = true;
        }
        else
        {
            CopperButton.interactable = false;
        }

        if (SkillTreeNumber8 == SkilTreeMaxNumber8)
        {
            GoldButton.interactable = true;
        }
        else
        {
            GoldButton.interactable = false;
        }

        if (SkillTreeNumber9 == SkilTreeMaxNumber9)
        {
            DarkGoldText.gameObject.SetActive(true);
            DarkGoldIamge.gameObject.SetActive(true);
            DarkGoldTextMain.gameObject.SetActive(true);
            MenuArtifact.interactable = true;
        }
        else
        {
            DarkGoldText.gameObject.SetActive(false);
            DarkGoldIamge.gameObject.SetActive(false);
            DarkGoldTextMain.gameObject.SetActive(false);
            MenuArtifact.interactable = false;
        }

        if (CheckUnlockArtefact0 == 1)
        {
            Artifact0.interactable = true;
        }
        else
        {
            Artifact0.interactable = false;
        }

        if (CheckUnlockArtefact1 == 1)
        {
            Artifact1.interactable = true;
        }
        else
        {
            Artifact1.interactable = false;
        }
    }

    public void UpdateXpSlider()
    {
        XpSlider.maxValue = (float)LvlMaxXp;
        XpSlider.value = (float)LvlXp;

    }

    private void OnEnable()
    {
        YandexGame.GetDataEvent += GetLoad;
    }

    private void OnDisable()
    {
        YandexGame.GetDataEvent -= GetLoad;
    }

    public void GetLoad()
    {
        DarkGold = YandexGame.savesData.DarkGoldSave;
        TimerAutoSave = YandexGame.savesData.AutoSaveTimer;
        LevelPoint = YandexGame.savesData.LevelPointSave;
        Score = YandexGame.savesData.ScoreSave;
        MaxScore = YandexGame.savesData.MaxScoreSave;
        SkillNumber = YandexGame.savesData.SkillNumberSave;
        Gold = YandexGame.savesData.GoldSave;
        GoldChance = YandexGame.savesData.GoldChanceSave;
        LevelPoint = YandexGame.savesData.LevelPointSave;
        Level = YandexGame.savesData.LevelSave;
        LvlChance = YandexGame.savesData.LvlChanceSave;
        LvlMaxXp = YandexGame.savesData.LvlMaxXpSave;
        LvlXp = YandexGame.savesData.LvlXpSave;
        SkillNumber2 = YandexGame.savesData.SkillNumber2Save;
        ScoreMulti = YandexGame.savesData.ScoreMultiSave;
        ScoreMultiChance = YandexGame.savesData.ScoreMultiChanceSave;
        SkillNumber3 = YandexGame.savesData.SkillNumber3Save;
        XpMulti = YandexGame.savesData.XpMultiSave;
        XpMultiChance = YandexGame.savesData.XpMultiChanceSave;
        ScoreClickMulti = YandexGame.savesData.ScoreClickMultiSave;
        SkillNumber4 = YandexGame.savesData.SkillNumber4Save;
        SkillNumber5 = YandexGame.savesData.SkillNumber5Save;

        ScoreValueTimePlus = YandexGame.savesData.ScoreValueTimePlusSave;
        SkillTreeCost = YandexGame.savesData.SkillTreeCostSave;
        SkillTreeNumber0 = YandexGame.savesData.SkillTreeNumber0Save;

        GoldValueTimePlus = YandexGame.savesData.GoldValueTimePlusSave;
        SkillTreeCost1 = YandexGame.savesData.SkillTreeCost1Save;
        SkillTreeNumber1 = YandexGame.savesData.SkillTreeNumber1Save;

        XpValueTimePlus = YandexGame.savesData.XpValueTimePlusSave;
        SkillTreeCost2 = YandexGame.savesData.SkillTreeCost2Save;
        SkillTreeNumber2 = YandexGame.savesData.SkillTreeNumber2Save;

        GoldChanceSkillTree = YandexGame.savesData.GoldChanceSkillTreeSave;
        SkillTreeCost3 = YandexGame.savesData.SkillTreeCost3Save;
        SkillTreeNumber3 = YandexGame.savesData.SkillTreeNumber3Save;

        UlockButtonBananaSkill1.gameObject.SetActive(YandexGame.savesData.BananaButtonSkillSave);
        UnlockButtonBananaSkill2.gameObject.SetActive(YandexGame.savesData.BananaButtonSkill2Save);
        UnlockButtonBananaSkill3.gameObject.SetActive(YandexGame.savesData.BananaButtonSkill3Save);
        UnlockButtonBananaSkill4.gameObject.SetActive(YandexGame.savesData.BananaButtonSkill4Save);
        UnlockButtonBananaSkill5.gameObject.SetActive(YandexGame.savesData.BananaButtonSkill5Save);
        BananaImage.sprite = SkinSelected[YandexGame.savesData.ActualSkin];

        InvinsibleButtonSkillTreeLock0.gameObject.SetActive(YandexGame.savesData.InvinsibleButtonSkillTreeLock0Save);
        InvinsibleButtonSkillTreeLock1.gameObject.SetActive(YandexGame.savesData.InvinsibleButtonSkillTreeLock1Save);
        InvinsibleButtonSkillTreeLock2.gameObject.SetActive(YandexGame.savesData.InvinsibleButtonSkillTreeLock2Save);
        InvinsibleButtonSkillTreeLock3.gameObject.SetActive(YandexGame.savesData.InvinsibleButtonSkillTreeLock3Save);

        SkillTreeLock0.gameObject.SetActive(YandexGame.savesData.SkillTreeLockSave);
        SkillTreeLock1.gameObject.SetActive(YandexGame.savesData.SkillTreeLockSave1);
        SkillTreeLock2.gameObject.SetActive(YandexGame.savesData.SkillTreeLockSave2);

        GoldMultiSkillTree = YandexGame.savesData.GoldMultiSkillTreeSave;
        SkillTreeNumber4 = YandexGame.savesData.SkillTreeNumber4Save;
        SkillTreeCost4 = YandexGame.savesData.SkillTreeCost4Save;
        SkillTreeLock3.gameObject.SetActive(YandexGame.savesData.SkillTreeLockSave3);
        InvinsibleButtonSkillTreeLock4.gameObject.SetActive(YandexGame.savesData.InvinsibleButtonSkillTreeLock4Save);

        XpMultiSkillTree = YandexGame.savesData.XpMultiSkillTreeSave;
        SkillTreeNumber5 = YandexGame.savesData.SkillTreeNumber5Save;
        SkillTreeCost5 = YandexGame.savesData.SkillTreeCost5Save;
        SkillTreeLock4.gameObject.SetActive(YandexGame.savesData.SkillTreeLockSave4);
        InvinsibleButtonSkillTreeLock5.gameObject.SetActive(YandexGame.savesData.InvinsibleButtonSkillTreeLock5Save);

        SkillTreeLock5.gameObject.SetActive(YandexGame.savesData.SkillTreeLockSave5);
        SkillTreeNumber6 = YandexGame.savesData.SkillTreeNumber6Save;
        SkillTreeCost6 = YandexGame.savesData.SkillTreeCost6Save;

        SkillTreeLock6.gameObject.SetActive(YandexGame.savesData.SkillTreeLockSave6);
        SkillTreeNumber7 = YandexGame.savesData.SkillTreeNumber7Save;
        SkillTreeCost7 = YandexGame.savesData.SkillTreeCost7Save;

        SkillTreeLock7.gameObject.SetActive(YandexGame.savesData.SkillTreeLockSave7);
        SkillTreeNumber8 = YandexGame.savesData.SkillTreeNumber8Save;
        SkillTreeCost8 = YandexGame.savesData.SkillTreeCost8Save;

        SkillTreeLock8.gameObject.SetActive(YandexGame.savesData.SkillTreeLockSave8);
        SkillTreeNumber9 = YandexGame.savesData.SkillTreeNumber9Save;
        DarkGoldChance = YandexGame.savesData.DarkGoldChanceSave;
        SkillTreeCost9 = YandexGame.savesData.SkillTreeCost9Save;

        SkillTreeLock9.gameObject.SetActive(YandexGame.savesData.SkillTreeLockSave9);
        SkillTreeNumber10 = YandexGame.savesData.SkillTreeNumber10Save;
        SkillTreeCost10 = YandexGame.savesData.SkillTreeCost10Save;

        SkillTreeLock10.gameObject.SetActive(YandexGame.savesData.SkillTreeLockSave10);
        SkillTreeNumber11 = YandexGame.savesData.SkillTreeNumber11Save;
        SkillTreeCost11 = YandexGame.savesData.SkillTreeCost11Save;

        //!!!!!!!!!!!!!!!!!!!!!!!OreSave!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        OreIronTime = YandexGame.savesData.OreIronTimeSave;
        OreIronCostUpgrade = YandexGame.savesData.OreIronCostUpgradeSave;
        OreIronUpgrade = YandexGame.savesData.OreIronUpgradeSave;
        OreIron = YandexGame.savesData.OreIronSave;
        IngotIron = YandexGame.savesData.IngotIronSave;
        OreIronNumber = YandexGame.savesData.OreIronNumberSave;

        OreCopperTime = YandexGame.savesData.OreCopperTimeSave;
        OreCopperCostUpgrade = YandexGame.savesData.OreCopperCostUpgradeSave;
        OreCopperUpgrade = YandexGame.savesData.OreCopperUpgradeSave;
        OreCopper = YandexGame.savesData.OreCopperSave;
        IngotCopper = YandexGame.savesData.IngotCopperSave;
        OreCopperNumber = YandexGame.savesData.OreCopperNumberSave;

        OreGoldTime = YandexGame.savesData.OreGoldTimeSave;
        OreGoldCostUpgrade = YandexGame.savesData.OreGoldCostUpgradeSave;
        OreGoldUpgrade = YandexGame.savesData.OreGoldUpgradeSave;
        OreGold = YandexGame.savesData.OreGoldSave;
        IngotGold = YandexGame.savesData.IngotGoldSave;
        OreGoldNumber = YandexGame.savesData.OreGoldNumberSave;

        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!Меню Сражений!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!//

        PLayerHp = YandexGame.savesData.PLayerHpSave;
        PlayerMaxHp = YandexGame.savesData.PlayerMaxHpSave;
        PlayerDamage = YandexGame.savesData.PlayerDamageSave;
        PlayerDamageTap = YandexGame.savesData.PlayerDamageTapSave;
        PlayerCriticalDamageMulti = YandexGame.savesData.PlayerCriticalDamageMultiSave;
        PlayerCriticalDamageChance = YandexGame.savesData.PlayerCriticalDamageChanceSave;
        PlayerDamageTime = YandexGame.savesData.PlayerDamageTimeSave;
        PlayerEnemyDamageTime = YandexGame.savesData.PlayerEnemyDamageTimeSave;

        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!Меню Артифактов!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!//

        ArtifactUpgradeNumber0 = YandexGame.savesData.ArtifactUpgradeNumber0Save;
        ArtifactGoldCost0 = YandexGame.savesData.ArtifactGoldCostSave0;
        ArtifactDarkGoldCost0 = YandexGame.savesData.ArtifactDarkGoldCostSave0;
        ArtifactScoreCost0 = YandexGame.savesData.ArtifactScoreCostSave0;
        ArtifactIronCost0 = YandexGame.savesData.ArtifactIronCostSave0;
        CheckUnlockArtefact0 = YandexGame.savesData.CheckUnlockArtefactSave0;

        ArtifactUpgradeNumber1 = YandexGame.savesData.ArtifactUpgradeNumberSave1;
        ArtifactGoldCost1 = YandexGame.savesData.ArtifactGoldCostSave1;
        ArtifactDarkGoldCost1 = YandexGame.savesData.ArtifactDarkGoldCostSave1;
        ArtifactScoreCost1 = YandexGame.savesData.ArtifactScoreCostSave1;
        ArtifactCopperCost1 = YandexGame.savesData.ArtifactCopperCostSave1;
        CheckUnlockArtefact1 = YandexGame.savesData.CheckUnlockArtefactSave1;
    }

    public void SaveGame()
    {
        YandexGame.savesData.DarkGoldSave = DarkGold;
        YandexGame.savesData.LevelPointSave = LevelPoint;
        YandexGame.savesData.ScoreSave = Score;
        YandexGame.savesData.MaxScoreSave = MaxScore;
        YandexGame.savesData.SkillNumberSave = SkillNumber;
        YandexGame.savesData.GoldSave = Gold;
        YandexGame.savesData.GoldChanceSave = GoldChance;
        YandexGame.savesData.LevelSave = Level;
        YandexGame.savesData.LvlChanceSave = LvlChance;
        YandexGame.savesData.LvlMaxXpSave = LvlMaxXp;
        YandexGame.savesData.LvlXpSave = LvlXp;
        YandexGame.savesData.SkillNumber2Save = SkillNumber2;
        YandexGame.savesData.ScoreMultiSave = ScoreMulti;
        YandexGame.savesData.ScoreMultiChanceSave = ScoreMultiChance;
        YandexGame.savesData.SkillNumber3Save = SkillNumber3;
        YandexGame.savesData.XpMultiSave = XpMulti;
        YandexGame.savesData.XpMultiChanceSave = XpMultiChance;
        YandexGame.savesData.ScoreClickMultiSave = ScoreClickMulti;
        YandexGame.savesData.SkillNumber4Save = SkillNumber4;
        YandexGame.savesData.SkillNumber5Save = SkillNumber5;
        YandexGame.savesData.ScoreValueTimePlusSave = ScoreValueTimePlus;
        YandexGame.savesData.SkillTreeCostSave = SkillTreeCost;
        YandexGame.savesData.SkillTreeNumber0Save = SkillTreeNumber0;
        YandexGame.savesData.GoldValueTimePlusSave = GoldValueTimePlus;
        YandexGame.savesData.SkillTreeCost1Save = SkillTreeCost1;
        YandexGame.savesData.SkillTreeNumber1Save = SkillTreeNumber1;
        YandexGame.savesData.XpValueTimePlusSave = XpValueTimePlus;
        YandexGame.savesData.SkillTreeCost2Save = SkillTreeCost2;
        YandexGame.savesData.SkillTreeNumber2Save = SkillTreeNumber2;
        YandexGame.savesData.GoldChanceSkillTreeSave = GoldChanceSkillTree;
        YandexGame.savesData.SkillTreeCost3Save = SkillTreeCost3;
        YandexGame.savesData.SkillTreeNumber3Save = SkillTreeNumber3;
        YandexGame.savesData.GoldMultiSkillTreeSave = GoldMultiSkillTree;
        YandexGame.savesData.SkillTreeCost4Save = SkillTreeCost4;
        YandexGame.savesData.SkillTreeNumber4Save = SkillTreeNumber4;
        YandexGame.savesData.XpMultiSkillTreeSave = XpMultiSkillTree;
        YandexGame.savesData.SkillTreeCost5Save = SkillTreeCost5;
        YandexGame.savesData.SkillTreeNumber5Save = SkillTreeNumber5;
        YandexGame.savesData.SkillTreeCost6Save = SkillTreeCost6;
        YandexGame.savesData.SkillTreeNumber6Save = SkillTreeNumber6;
        YandexGame.savesData.SkillTreeCost7Save = SkillTreeCost7;
        YandexGame.savesData.SkillTreeNumber7Save = SkillTreeNumber7;

        YandexGame.savesData.SkillTreeCost8Save = SkillTreeCost8;
        YandexGame.savesData.SkillTreeNumber8Save = SkillTreeNumber8;

        YandexGame.savesData.SkillTreeCost9Save = SkillTreeCost9;
        YandexGame.savesData.SkillTreeNumber9Save = SkillTreeNumber9;
        YandexGame.savesData.DarkGoldChanceSave = DarkGoldChance;

        YandexGame.savesData.SkillTreeCost10Save = SkillTreeCost10;
        YandexGame.savesData.SkillTreeNumber10Save = SkillTreeNumber10;

        YandexGame.savesData.SkillTreeCost11Save = SkillTreeCost11;
        YandexGame.savesData.SkillTreeNumber11Save = SkillTreeNumber11;

        //!!!!!!!!!!!!!!!!!!!!!!!OreSave!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        YandexGame.savesData.OreIronTimeSave = OreIronTime;
        YandexGame.savesData.OreIronCostUpgradeSave = OreIronCostUpgrade;
        YandexGame.savesData.OreIronUpgradeSave = OreIronUpgrade;
        YandexGame.savesData.OreIronSave = OreIron;
        YandexGame.savesData.IngotIronSave = IngotIron;
        YandexGame.savesData.OreIronNumberSave = OreIronNumber;

        YandexGame.savesData.OreCopperTimeSave = OreCopperTime;
        YandexGame.savesData.OreCopperCostUpgradeSave = OreCopperCostUpgrade;
        YandexGame.savesData.OreCopperUpgradeSave = OreCopperUpgrade;
        YandexGame.savesData.OreCopperSave = OreCopper;
        YandexGame.savesData.IngotCopperSave = IngotCopper;
        YandexGame.savesData.OreCopperNumberSave = OreCopperNumber;

        YandexGame.savesData.OreGoldTimeSave = OreGoldTime;
        YandexGame.savesData.OreGoldCostUpgradeSave = OreGoldCostUpgrade;
        YandexGame.savesData.OreGoldUpgradeSave = OreGoldUpgrade;
        YandexGame.savesData.OreGoldSave = OreGold;
        YandexGame.savesData.IngotGoldSave = IngotGold;
        YandexGame.savesData.OreGoldNumberSave = OreGoldNumber;

        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!Меню Сражений!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!//

        YandexGame.savesData.PLayerHpSave = PLayerHp;
        YandexGame.savesData.PlayerMaxHpSave = PlayerMaxHp;
        YandexGame.savesData.PlayerDamageSave = PlayerDamage;
        YandexGame.savesData.PlayerDamageTapSave = PlayerDamageTap;
        YandexGame.savesData.PlayerCriticalDamageMultiSave = PlayerCriticalDamageMulti;
        YandexGame.savesData.PlayerCriticalDamageChanceSave = PlayerCriticalDamageChance;
        YandexGame.savesData.PlayerDamageTimeSave = PlayerDamageTime;
        YandexGame.savesData.PlayerEnemyDamageTimeSave = PlayerEnemyDamageTime;

        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!Меню Артифактов!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!//

        YandexGame.savesData.ArtifactUpgradeNumber0Save = ArtifactUpgradeNumber0;
        YandexGame.savesData.ArtifactGoldCostSave0 = ArtifactGoldCost0;
        YandexGame.savesData.ArtifactDarkGoldCostSave0 = ArtifactDarkGoldCost0;
        YandexGame.savesData.ArtifactScoreCostSave0 = ArtifactScoreCost0;
        YandexGame.savesData.ArtifactIronCostSave0 = ArtifactIronCost0;
        YandexGame.savesData.CheckUnlockArtefactSave0 = CheckUnlockArtefact0;

        YandexGame.savesData.ArtifactUpgradeNumberSave1 = ArtifactUpgradeNumber1;
        YandexGame.savesData.ArtifactGoldCostSave1 = ArtifactGoldCost1;
        YandexGame.savesData.ArtifactDarkGoldCostSave1 = ArtifactDarkGoldCost1;
        YandexGame.savesData.ArtifactScoreCostSave1 = ArtifactScoreCost1;
        YandexGame.savesData.ArtifactCopperCostSave1 = ArtifactCopperCost1;
        YandexGame.savesData.CheckUnlockArtefactSave1 = CheckUnlockArtefact1;

        YandexGame.SaveProgress();
    }

    public void AutoSaveGame()
    {
        TimerAutoSave -= 1;
        if (TimerAutoSave == 0)
        {
            TimerAutoSave = 60;
            AutoSaveImage.gameObject.SetActive(true);
            SaveGame();
        }
        if (TimerAutoSave == 55)
        {
            AutoSaveImage.gameObject.SetActive(false);
        }
    }

    public void ResetGame()
    {
        YandexGame.ResetSaveProgress();
        SkinDiscription.text = "...";
        SkiSkillDiscription.text = "...";
        MinMaxUpgradeText.text = "...";
        SkillUpdateDisc.text = "...";
        UpdateUi();
    }

    public void CheatGame()
    {
        Score += 100000;
        LevelPoint += 1000;
        Gold += 100000;
        UpdateUi();
    }
}
