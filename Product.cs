
public class Product
{
    private string _name;
    private int _count;
    private int _price; 
    public string Name
    {
        get => _name; set
        {
            if (value.Length > 0)
            { _name = value; }
            else if (value.Length==0) 
            {
                Console.WriteLine("Duzgun ad daxil edin");
            }
        }
    }
    public int Price
    {
        get => _price; set
        {
            if (value >= 1)
            {
                _price = value;
            }
            else if (value < 1)
            {
                Console.WriteLine("Qiymet 1 aznden ashagi ola bilmez.");
            }
        }
    }
       
    public int Count 
    { 
        get => _count; set 
        
        {
            if (value>0)
            {
              _count= value;
            }

        } 
    }
        
        
    public int TotalIncome;
    public void Sell(int Count,int Price)
    {
        while (Count >= 1&&Price>=1) { 
        Count--;
        TotalIncome+=Price;
        Console.WriteLine($"{Count} eded mehsul qalmishdir.");
        Console.WriteLine($"Umumi gelir {TotalIncome} manatdir.");
            
        }
         if(Count==0)
        {
            Console.WriteLine("Mehsul bitmishdir.");
        }
         else if (Price < 1||Count<0)
        {
            Console.WriteLine("Duzgun eded daxil edin");
        }
        
        
    }

    

    

    }


