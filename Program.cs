namespace Project_6;

class Program{
    static public void InputInFile(){
        string path = @"Information_Employees.txt";
        int id = 0;
        if(File.Exists(path)) 
            id = File.ReadAllLines(path).Length;
        DateTime date, birthDay = new DateTime();
        date = DateTime.Now;
        Console.Write("Full name: ");
        string? fullName = Console.ReadLine();
        Console.Write("Height: ");
        byte height = Convert.ToByte(Console.ReadLine());
        Console.Write("Birth day (Year.Month.Day): ");
        birthDay = Convert.ToDateTime(Console.ReadLine());
        Console.Write("Birth place: ");
        string? birthPlace = Console.ReadLine();
        byte age = Convert.ToByte(date.Year - birthDay.Year);
        using (StreamWriter sw = new StreamWriter(path, true)){
            id++;
            sw.WriteLine(id + "#" + date.ToString("dd/MM/yyyy HH:mm") + "#" + fullName + "#" + age + "#" + height + "#" + birthDay.ToString("dd/MM/yyyy") + "#" + birthPlace);
        }
        Console.Clear();
    }
    static public void OutputFromFile(){
        string path = @"Information_Employees.txt";
        using (StreamReader readFile = new StreamReader(path))
        {
            string? stringFromFile;
            while ((stringFromFile = readFile.ReadLine()) != null){
                string[] consoleWrite  = stringFromFile.Split('#');
                foreach (var el in consoleWrite){
                    Console.Write($"{el} ");
                }
                Console.WriteLine();
            }
        }
        Console.ReadLine();
        Console.Clear();
    }
    static public void Main(){
        bool s = false;
        while(!s){
            Console.WriteLine("watch - Display information about employees;");
            Console.WriteLine("add - Add a new entry to the end of the file;");
            Console.WriteLine("exit - Close program.");
            Console.Write("Select comand: ");
            string? comand = Console.ReadLine();
            switch (comand){
                case "watch":
                    Console.Clear();
                    OutputFromFile();
                    break;
                case "add":
                    Console.Clear();
                    InputInFile();
                    break;
                case "exit":
                    Console.Clear();
                    s = true;
                    break;
                default:
                    Console.WriteLine("Comand not found!");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }      
        }
    }
}