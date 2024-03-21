using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
