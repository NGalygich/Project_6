namespace Project_6;

class Program{

    static public void InputInFile(){
        short id;
        string fullName;
        byte age;
        sbyte height;
        string birthDay;
        string birthPlace;
    }
    static public void OutputFromFile(){

    }
    static public void Main(){
        Console.WriteLine("1 - Display information about employees;");
        Console.WriteLine("2 - Add a new entry to the end of the file.");
        Console.Write("Select action: ");
        byte choice = Convert.ToByte(Console.ReadLine());
        if (choice == 1) InputInFile();
        else OutputFromFile();
    }
}