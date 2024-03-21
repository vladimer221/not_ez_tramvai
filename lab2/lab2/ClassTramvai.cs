namespace lab2;

/// <summary>
/// Класс-сущность "Трамвая с горомошкой"
/// </summary>
public class ClassTramvai
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
    /// Допольнительный цвет (для опциональный элементов)
    /// </summary>
    public Color AdditionalColor { get; private set; }

    /// <summary>
    /// признак (опция) наличия гормошки
    /// </summary>
    public bool Accordion { get; private set; }

    /// <summary>
    /// Признак (опция) наличия отсеки
    /// </summary>
    public bool Line { get; private set; }

    /// <summary>
    /// Признак (опция) наличия двери
    /// </summary>
    public bool SecondDoor { get; private set; }

    /// <summary>
    /// Шаг перемещения автобуса
    /// </summary>
    public double Step => Speed * 100 / Weight;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="speed"></param>
    /// <param name="weight"></param>
    /// <param name="bodycolor"></param>
    /// <param name="additionalColor"></param>
    /// <param name="accordion"></param>
    /// <param name="line"></param>
    /// <param name="seconddoor"></param>

    public void Init(int speed, double weight, Color bodycolor, Color additionalColor, bool accordion, bool line, bool seconddoor)
    {
        Speed = speed;
        Weight = weight;
        BodyColor = bodycolor;
        AdditionalColor = additionalColor;
        Accordion = accordion;
        Line = line;
        SecondDoor = seconddoor;
    }
}