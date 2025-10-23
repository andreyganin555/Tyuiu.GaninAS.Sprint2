using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GaninAS.Sprint2.Task6.V6.Lib
{

}

public class DataService : ISprint2Task6V6
{
    public string FindCardNameAndValue(int suit, int rank)
    {
        // Определение масти
        string suitName = "";
        switch (suit)
        {
            case 1:
                suitName = "пики";
                break;
            case 2:
                suitName = "трефы";
                break;
            case 3:
                suitName = "бубны";
                break;
            case 4:
                suitName = "червы";
                break;
            default:
                throw new ArgumentException($"Масть карты должна быть от 1 до 4. Значение: {suit}");
        }

        // Определение достоинства
        string rankName = "";
        switch (rank)
        {
            case 6:
                rankName = "шестерка";
                break;
            case 7:
                rankName = "семерка";
                break;
            case 8:
                rankName = "восьмерка";
                break;
            case 9:
                rankName = "девятка";
                break;
            case 10:
                rankName = "десятка";
                break;
            case 11:
                rankName = "валет";
                break;
            case 12:
                rankName = "дама";
                break;
            case 13:
                rankName = "король";
                break;
            case 14:
                rankName = "туз";
                break;
            default:
                throw new ArgumentException($"Номер достоинства должен быть от 6 до 14. Значение: {rank}");
        }

        // Возвращаем полное название карты
        return $"{rankName} {suitName}";
    }
}












