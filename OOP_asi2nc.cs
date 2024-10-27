//OOP_asi2nc
car c = new car("BMW","2006");
c.print();

truck t = new truck("mercedes", "2025");
t.print();
Console.ReadLine();

class veachle
{
  protected   string Brand;
}
abstract class motorveachle : veachle
{
   protected string model;
    
    public abstract  void print ();
    
}
class car:motorveachle
{
    public car(string Brand,string model)
    {
        this.Brand = Brand;
        this.model = model;
    }
    public override void print()
    {
        Console.WriteLine("Brand  : "+ Brand );
        Console.WriteLine("model  : " + model);
    }
}
class truck : motorveachle
{
    public truck(string Brand, string model)
    {
        this.Brand = Brand;
        this.model = model;
    }
    public override void print()
    {
        Console.WriteLine("Brand  : " + Brand);
        Console.WriteLine("model  : " + model);
    }
}
