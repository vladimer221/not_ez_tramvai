using notez.entities;

namespace notez.Drawnings;

public static class ExtentionDrawningBus
{
    private static readonly string _separatorForObject = ":";

    public static DrawningTramvaiBus? CreateDrawningTramvaiBus(this string info)
    {
        string[] strs = info.Split(_separatorForObject);
        ClassTramvai? tramvai = ClassTramvai.CreateClassTramvai(strs);
        if (tramvai != null)
        {
            return new DrawningTramvai(Convert.ToInt32(strs[1]), Convert.ToDouble(strs[2]), Color.FromName(strs[3]), Color.FromName(strs[4]), Color.FromName(strs[5]), Convert.ToBoolean(strs[6]), Convert.ToBoolean(strs[7]));
        }

        ClassTramvaiBus? bus = ClassTramvaiBus.CreateClassTramvaiBus(strs);
        if (bus != null) 
        {
           return new DrawningTramvaiBus(Convert.ToInt32(strs[1]), Convert.ToDouble(strs[2]), Color.FromName(strs[3]));
        }

        return null;

    }

    public static string GetDataForSave(this DrawningTramvaiBus drawningTramvaiBus) 
    {
        string[]? array = drawningTramvaiBus?.ClassTramvaiBus?.GetStringRepresentation();

        if (array == null)
        {
            return string.Empty;
        }

        return string.Join(_separatorForObject, array); 
    }
}
