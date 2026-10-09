namespace Focus
{
    internal class ProgressionSystem
    {
        // Kinda literal, calculate required xp
        public static int CalculateRequiredXp(int playerLevel, int playerXp)
        {
            int NextLevelGoal;
            int RequiredXp;

            NextLevelGoal = playerLevel * 100;
            return RequiredXp = NextLevelGoal - playerXp;
        }

        // Add xp after focus
        public static int AddXp(int PlayerXp)
        {
            return PlayerXp + 50;
        }

        //Message about Player´s Xp to main
        public static string GetXpStatus(int playerLevel, int playerXp)
        {
            int requiredXp = CalculateRequiredXp(playerLevel, playerXp);

            return $"Level: {playerLevel}\n" +
            $"XP: {playerXp}\n" +
            $"{requiredXp} XP for the next level\n";
        }

        //Level Up check and add
        public static bool LevelCheck(Player player)
        {
            int NextLevelGoal;

            NextLevelGoal = player.level * 100;
            if(NextLevelGoal == player.xp)
            {
                player.level++;
                player.xp = 0;
                return true;
            }
            return false;
        }


    }
}
