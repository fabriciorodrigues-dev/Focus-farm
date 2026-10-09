namespace Focus
{
    internal class Player
    {
        public string name;
        public string occupation;
        public bool focusMode = false;
        public int focusSessions = 0;
        public int xp = 0;
        public int level = 1;

        //Define Occupation
        public static string DefineOccupation(int temp)
        {
            switch (temp)
            {
                case 1:
                    return "Elementary school student";
                case 2:
                    return "High school student";
                case 3:
                    return "Higher education student";
                case 4:
                    return "Professional";
                case 5:
                    return "Not currently studying or working";
                default:
                    return "null";
            }
        }

        // Contructor
        public Player(string name, string occupation)
        {
            this.name = name;
            this.occupation = occupation;
        }
    }
}
