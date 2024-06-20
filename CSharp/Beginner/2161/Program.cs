class Program
{
    static void Main(string[] args)
    {
        string[] line = Console.ReadLine().Split(' ');
        int tabsInitial, tabsCount, tabsOpen, tabsClosed;
        tabsInitial = Convert.ToInt32(line[0]);
        tabsCount = Convert.ToInt32(line[1]);
        string tabAction;
        tabsOpen = tabsInitial;
        for(int i = 0; i < tabsCount; i++)
        {
            tabAction = Console.ReadLine();
            if(tabAction[0]=='f')
                tabsOpen += 1;
            else
                tabsOpen -= 1;
        }
        Console.WriteLine(tabsOpen);
    }
}
