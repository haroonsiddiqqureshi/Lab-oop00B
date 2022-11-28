// See https://aka.ms/new-console-template for more information
class Students
{
    public string name;
    public int weight;

    public Students(string Name,int Weight)
    {
        name = Name;
        weight = Weight;
    }
    static void Main(string[] args)
    {
        Students student1 = new Students("Kang", 82);
        Students student2 = new Students("Ta", 70);
        Students student3 = new Students("Palm", 72);
        Students student4 = new Students("Ter", 73);
        Students student5 = new Students("Prajak", 80);
        int[] weightList = { student1.weight, student2.weight, student3.weight, student4.weight, student5.weight };
        int max = weightList.Max();
        int min = weightList.Min();
        Console.WriteLine("ค่าเฉลี่ยน้ำหนักทั้งหมด " + (student1.weight + student2.weight + student3.weight + student4.weight + student5.weight)/5);
        Console.WriteLine("คนที่มีน้ำหนักมากที่สุด " + max);
        Console.WriteLine("คนที่มีน้ำหนักน้อยที่สุด " + min);
        Console.WriteLine("นายฮารูณ ซิดดิ๊ก คูเรซิ 653450300-1");
    }
}
