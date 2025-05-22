
namespace YG
{
    [System.Serializable]
    public class SavesYG
    {
        // "Технические сохранения" для работы плагина (Не удалять)
        public int idSave;
        public bool isFirstSession = true;
        public string language = "ru";
        public bool promptDone;

        // Тестовые сохранения для демо сцены
        // Можно удалить этот код, но тогда удалите и демо (папка Example)
        public int money = 1;                       // Можно задать полям значения по умолчанию
        public string newPlayerName = "Hello!";
        public bool[] openLevels = new bool[3];

        // Ваши сохранения

        public double ScoreSave = 0;
        public double MaxScoreSave = 0;
        public int SkillNumberSave = 0;
        public int GoldSave = 0;
        public int GoldChanceSave = 0;
        public int LevelPointSave = 0;
        public int LevelSave = 0;
        public int LvlChanceSave = 30;
        public double LvlXpSave = 0;
        public float LvlMaxXpSave = 100;
        public int SkillNumber2Save = 0;
        public int ScoreMultiSave = 1;
        public int ScoreMultiChanceSave = 0;
        public int SkillNumber3Save = 0;
        public int XpMultiSave = 1;
        public int XpMultiChanceSave = 0;
        public int SkillNumber4Save = 0;
        public int ScoreClickMultiSave = 1;
        public int SkillNumber5Save = 0;
        public int DarkGoldSave = 0;

        public bool MainMenuButtonSave = false;
        public bool BananaButtonSkillSave = true;
        public bool BananaButtonSkill2Save = true;
        public bool BananaButtonSkill3Save = true;
        public bool BananaButtonSkill4Save = true;
        public bool BananaButtonSkill5Save = true;

        public int ActualSkin = 0;

        public bool SkillTreeLockSave = true;
        public bool SkillTreeLockSave1 = true;
        public bool SkillTreeLockSave2 = true;

        public bool InvinsibleButtonSkillTreeLock0Save = true;
        public int SkillTreeNumber0Save = 0;
        public int ScoreValueTimePlusSave = 0;
        public int SkillTreeCostSave = 500;

        public bool InvinsibleButtonSkillTreeLock1Save = true;
        public int SkillTreeNumber1Save = 0;
        public int GoldValueTimePlusSave = 0;
        public int SkillTreeCost1Save = 1000;

        public bool InvinsibleButtonSkillTreeLock2Save = true;
        public int SkillTreeNumber2Save = 0;
        public int XpValueTimePlusSave = 0;
        public int SkillTreeCost2Save = 1250;

        public bool InvinsibleButtonSkillTreeLock3Save = true;
        public int SkillTreeNumber3Save = 0;
        public int GoldChanceSkillTreeSave = 0;
        public int SkillTreeCost3Save = 1500;

        public bool InvinsibleButtonSkillTreeLock4Save = true;
        public bool SkillTreeLockSave3 = true;
        public int SkillTreeNumber4Save = 0;
        public int GoldMultiSkillTreeSave = 0;
        public int SkillTreeCost4Save = 1750;

        public bool InvinsibleButtonSkillTreeLock5Save = true;
        public bool SkillTreeLockSave4 = true;
        public int SkillTreeNumber5Save = 0;
        public int XpMultiSkillTreeSave = 1;
        public int SkillTreeCost5Save = 1500;

        public bool SkillTreeLockSave5 = true;
        public int SkillTreeNumber6Save = 0;
        public int SkillTreeCost6Save = 3000;
        public bool MenuCaveButtonSave = false;

        public bool SkillTreeLockSave6 = true;
        public int SkillTreeNumber7Save = 0;
        public int SkillTreeCost7Save = 7000;

        public bool SkillTreeLockSave7 = true;
        public int SkillTreeNumber8Save = 0;
        public int SkillTreeCost8Save = 12000;

        public bool SkillTreeLockSave8 = true;
        public int SkillTreeNumber9Save = 0;
        public int DarkGoldChanceSave = 0;
        public int SkillTreeCost9Save = 20000;

        public bool SkillTreeLockSave9 = true;
        public int SkillTreeNumber10Save = 0;
        public int SkillTreeCost10Save = 250;

        public bool SkillTreeLockSave10 = true;
        public int SkillTreeNumber11Save = 0;
        public int SkillTreeCost11Save = 2500;

        //!!!!!!!!!!!!!!!!!Меню шахты!!!!!!!!!!!!!!!!!!!!!!!!

        public float OreIronTimeSave = 20f;
        public int OreIronCostUpgradeSave = 3000;
        public int OreIronUpgradeSave = 1;
        public int OreIronSave = 0;
        public int IngotIronSave = 0;
        public int OreIronNumberSave = 1;

        public float OreCopperTimeSave = 30f;
        public int OreCopperCostUpgradeSave = 5000;
        public int OreCopperUpgradeSave = 1;
        public int OreCopperSave = 0;
        public int IngotCopperSave = 0;
        public int OreCopperNumberSave = 1;

        public float OreGoldTimeSave = 45f;
        public int OreGoldCostUpgradeSave = 7000;
        public int OreGoldUpgradeSave = 1;
        public int OreGoldSave = 0;
        public int IngotGoldSave = 0;
        public int OreGoldNumberSave = 1;

        //public bool MenuCaveIamgeSave = false;

        public int AutoSaveTimer = 60;

        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!Меню Артифактов!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!//

        public int ArtifactHpSave0 = 1;
        public int ArtifactDamageSave0 = 2;
        public int ArtifactCriticalDamageChanceSave0 = 1;
        public float ArtifactDamageTimeSave0 = 0.05f;
        public int ArtifactDamageTapSave0 = 1;

        public int ArtifactUpgradeNumber0Save = 0;

        public int ArtifactGoldCostSave0 = 30000;
        public int ArtifactDarkGoldCostSave0 = 5;
        public int ArtifactScoreCostSave0 = 50000;
        public int ArtifactIronCostSave0 = 150;

        public int CheckUnlockArtefactSave0 = 0;


        public int CheckUnlockArtefactSave1 = 0;
        public int ArtifactHpSave1 = 25;

        public int ArtifactUpgradeNumberSave1 = 0;

        public int ArtifactGoldCostSave1 = 40000;
        public int ArtifactDarkGoldCostSave1 = 10;
        public int ArtifactScoreCostSave1 = 100000;
        public int ArtifactCopperCostSave1 = 200;

        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!Меню Сражений!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!//

        public int PLayerHpSave = 10;
        public int PlayerMaxHpSave = 10;

        public int PlayerDamageSave = 5;
        public int PlayerDamageTapSave = 1;

        public int PlayerCriticalDamageMultiSave = 2;
        public int PlayerCriticalDamageChanceSave = 1;

        public float PlayerDamageTimeSave = 10;
        public float PlayerEnemyDamageTimeSave = 0;

        public SavesYG()
        {
            // Допустим, задать значения по умолчанию для отдельных элементов массива

            openLevels[1] = true;
        }
    }
}
