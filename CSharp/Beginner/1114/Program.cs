class Program
{
    static void Main(string[] args)
    {
        int correctPassword = 2002;
        bool isPassword = false;
        int password;
        while (isPassword == false)
        {
            password = Convert.ToInt32(Console.ReadLine());
            if (password != correctPassword)
                Console.WriteLine("Senha Invalida");
            else
            {
                Console.WriteLine("Acesso Permitido");
                isPassword = true;
            }
        }

    }
}
