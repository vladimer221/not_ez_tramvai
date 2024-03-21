namespace notez.entities;

/// <summary>
/// Класс-сущность "Трамвая с горомошкой"
/// </summary>
public class ClassTramvai : ClassTramvaiBus
{
    public Color AdditionalColor { get; private set; }

    public bool Accordion { get; private set; }

    public bool Line { get; private set; }

    public bool SecondDoor { get; private set; }

    public ClassTramvai(int speed, double weight, Color bodycolor, Color additionalColor, bool accordion, bool line, bool seconddoor) : base(speed, weight, bodycolor)
    {
        AdditionalColor = additionalColor;
        Accordion = accordion;
        Line = line;
        SecondDoor = seconddoor;
    }
}
