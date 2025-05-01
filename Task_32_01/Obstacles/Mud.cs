public class Mud : Obstacle
{
    public Mud() : base("Грязь") { }
    public override void Affect(Kolobok kolobok)
    {
        kolobok.SlowDown(1);
        Console.WriteLine($"Колобок попал в {Name} и замедлился!");
    }
}
