namespace notez.entities;

public class ClassTramvaiBus
{
    /// <summary>
    /// Скорость
    /// </summary>
    public int Speed { get; private set; }

    /// <summary>
    /// Вес
    /// </summary>
    public double Weight { get; private set; }

    /// <summary>
    /// Основной цвет
    /// </summary>
    public Color BodyColor { get; private set; }

    /// <summary>
    /// Шаг перемещения автобуса
    /// </summary>
    public double Step => Speed * 100 / Weight;

    /// <summary>
    /// Конструктор сущности
    /// </summary>
    /// <param name="speed"></param>
    /// <param name="weight"></param>
    /// <param name="bodycolor"></param>

    public ClassTramvaiBus(int speed, double weight, Color bodycolor)
    {
        Speed = speed;
        Weight = weight;
        BodyColor = bodycolor;
    }

    public virtual string[] GetStringRepresentation()
    { 
        return new[] {nameof(ClassTramvaiBus), Speed.ToString(), Weight.ToString(), BodyColor.Name };
    }

    public static ClassTramvaiBus? CreateClassTramvaiBus(string[] strs)
    {
        if (strs.Length != 4 || strs[0] != nameof(ClassTramvaiBus))
        {
            return null;
        }
        return new ClassTramvaiBus(Convert.ToInt32(strs[1]), Convert.ToDouble(strs[2]), Color.FromName(strs[3]));
    }
}
