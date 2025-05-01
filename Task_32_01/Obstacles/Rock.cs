public class Rock : Obstacle
{
    public Rock() : base("Камень") { }
    public override void Affect(Kolobok kolobok)
    {
        kolobok.SlowDown(2);
        Console.WriteLine($"Колобок ударился о {Name} и сильно замедлился!");
    }
}
