

Product Computer = new Product();
Computer.SetName("MackBook M1 Pro");
Computer.SetPrice(1100);
Computer.SetDescription("The newest apple laptop");
Computer.SetIva(22);

Console.WriteLine("prodotto");
Console.WriteLine(Computer.GetName());
Console.WriteLine(Computer.GetDescription());
Console.WriteLine(Computer.GetCode());
Console.WriteLine(Computer.GetPrice() + "$");
Console.WriteLine(Computer.GetIva());

Console.WriteLine(Computer.GetFullName());
Console.WriteLine("Prezzo con l'iva");
Console.WriteLine(Computer.GetPiceWithIva());




public class Product
{
  
    private int code;
    private string name;
    private string description;
    private decimal price;
    private int iva;

    
    public Product()
    {
        Random num = new Random();
        this.code = num.Next(0,100);
    }


    public void SetName(string name)
    {
        this.name = name;
    }
    public void SetDescription(string description)
    {
        this.description = description;
    }
    public void SetPrice(decimal price)
    {
        this.price = price;
    }
    public void SetIva(int iva)
    {
        this.iva = iva;
    }

    public int GetCode()
    {
        return this.code;
    }
    public string GetName()
    {
        return this.name;
    }
    public string GetDescription()
    {
        return this.description;
    }
    public decimal GetPrice()
    {
        return this.price;
    }
    public int GetIva()
    {
        return this.iva;
    }


    



    public decimal GetPiceWithIva()
    {
        return GetPrice() * (decimal)(GetIva() + 100) / 100;
    }
    public string GetFullName()
    {
        return GetName() + GetCode();
    }
    
}
