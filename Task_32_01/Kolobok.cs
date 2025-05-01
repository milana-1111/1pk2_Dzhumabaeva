public class Kolobok
{
    public int Position { get; private set; }
    public int Speed { get; private set; }
    public bool IsAlive { get; private set; }
    private int _originalSpeed;

    public Kolobok()
    {
        Position = 0;
        Speed = 3; // Начальная скорость увеличена для наглядности
        _originalSpeed = Speed;
        IsAlive = true;
    }

    public void Roll()
    {
        Position += Speed;
        Console.WriteLine($"Колобок катится, текущая позиция: {Position}, скорость: {Speed}");
    }

    public void MeetAnimal(Animal animal)
    {
        if (animal.CanEat(this))
        {
            IsAlive = false;
            Console.WriteLine($"Колобок был съеден {animal.Name}!");
        }
        else
        {
            Console.WriteLine($"Колобок убежал от {animal.Name}!");
        }
    }

    public void MeetObstacle(Obstacle obstacle)
    {
        obstacle.Affect(this);
    }

    public void SlowDown(int amount)
    {
        Speed = Math.Max(1, _originalSpeed - amount); // Скорость не может быть меньше 1
    }

    public void RestoreSpeed()
    {
        Speed = _originalSpeed;
    }
}
