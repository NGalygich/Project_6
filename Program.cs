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
    }
    static public void OutputFromFile(){
        //string path = @"Information_Employees.txt";
    }
    static public void Main(){
        bool s = false;
        while(!s){
            Console.WriteLine("1 - Display information about employees;");
            Console.WriteLine("2 - Add a new entry to the end of the file.");
            Console.Write("Select action: ");
            byte choice = Convert.ToByte(Console.ReadLine());
            if (choice == 1) OutputFromFile();
            else if (choice == 2) InputInFile();
            else s = true;
        }
    }
}