
public class Milk : Product
{
    public int Volume;
    public double FatRate;
    public void TotalVolume(int Count, int Volume,double FatRate)
    {
        Console.WriteLine($"Yag faizi {FatRate} olan mehsuldan {Volume *= Count} litr satilmishdir.");
    }
}

