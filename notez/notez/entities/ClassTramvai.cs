namespace notez.entities;

/// <summary>
/// Класс-сущность "Трамвая с горомошкой"
/// </summary>
public class ClassTramvai : ClassTramvaiBus
{
    public Color AdditionalColor { get; private set; }

    public Color AdditionalBodyColor { get; private set; }

    public bool Line { get; private set; }

    public bool SecondDoor { get; private set; }

    public ClassTramvai(int speed, double weight, Color bodycolor, Color additionalColor,Color additionalBodyColor, bool line, bool seconddoor) : base(speed, weight, bodycolor)
    {
        AdditionalColor = additionalColor;
        AdditionalBodyColor = additionalBodyColor;
        Line = line;
        SecondDoor = seconddoor;
    }

    public override string[] GetStringRepresentation()
    {
        return new[] { nameof(ClassTramvai), Speed.ToString(), Weight.ToString(), BodyColor.Name, AdditionalColor.Name, AdditionalBodyColor.Name, Line.ToString(), SecondDoor.ToString()};
    }

    public static ClassTramvai? CreateClassTramvai(string[] strs)
    {
        if (strs.Length != 8 || strs[0] != nameof(ClassTramvaiBus))
        {
            return null;
        }
        return new ClassTramvai(Convert.ToInt32(strs[1]), Convert.ToDouble(strs[2]), Color.FromName(strs[3]), Color.FromName(strs[4]), Color.FromName(strs[4]), Convert.ToBoolean(strs[5]), Convert.ToBoolean(strs[6])) ;
    }
}
