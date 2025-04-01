using System;
using System.Collections.Generic;

// Задание 1
public struct Article
{
    public int Code { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public ArticleType Type { get; set; } 
}

// Задание 2
public struct Client
{
    public int Code { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public int OrderCount { get; set; }
    public decimal TotalOrderAmount { get; set; }
    public ClientType ClientImportance { get; set; } 
}

// Задание 3
public struct RequestItem
{
    public Article Article { get; set; }
    public int Quantity { get; set; }
}

// Задание 4
public struct Request
{
    public int Code { get; set; }
    public Client Client { get; set; }
    public DateTime OrderDate { get; set; }
    public List<RequestItem> Items { get; set; }
    public PayType PaymentType { get; set; } 

    public decimal TotalAmount
    {
        get
        {
            decimal total = 0;
            if (Items != null)
            {
                foreach (var item in Items)
                {
                    total += item.Article.Price * item.Quantity;
                }
            }
            return total;
        }
    }
}

// Задание 5
public enum ArticleType
{
    Food,
    Electronics,
    Clothing,
    Books,
    Other
}

// Задание 6
public enum ClientType
{
    Regular,
    VIP,
    Wholesale
}

// Задание 7
public enum PayType
{
    Cash,
    CreditCard,
    OnlineTransfer
}

// Задание 8
public class Student
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string Group { get; set; }
    public int Age { get; set; }

    public int[][] Grades { get; set; } 
    public Student(int programmingAssessments, int administrationAssessments, int designAssessments)
    {
        Grades = new int[3][]; 
        Grades[0] = new int[programmingAssessments]; 
        Grades[1] = new int[administrationAssessments]; 
        Grades[2] = new int[designAssessments]; 
    }


    public void SetGrade(int subjectIndex, int assessmentIndex, int grade)
    {
        if (subjectIndex >= 0 && subjectIndex < Grades.Length &&
            assessmentIndex >= 0 && assessmentIndex < Grades[subjectIndex].Length)
        {
            Grades[subjectIndex][assessmentIndex] = grade;
        }
        else
        {
            Console.WriteLine("Некорректный индекс предмета или оценки.");
        }
    }

    public int GetGrade(int subjectIndex, int assessmentIndex)
    {
        if (subjectIndex >= 0 && subjectIndex < Grades.Length &&
            assessmentIndex >= 0 && assessmentIndex < Grades[subjectIndex].Length)
        {
            return Grades[subjectIndex][assessmentIndex];
        }
        else
        {
            Console.WriteLine("Некорректный индекс предмета или оценки.");
            return -1; 
        }
    }

    public double GetAverageGrade(int subjectIndex)
    {
        if (subjectIndex >= 0 && subjectIndex < Grades.Length)
        {
            if (Grades[subjectIndex].Length == 0) {
                return 0; 
            }
            int sum = 0;
            foreach (int grade in Grades[subjectIndex])
            {
                sum += grade;
            }
            return (double)sum / Grades[subjectIndex].Length;
        }
        else
        {
            Console.WriteLine("Некорректный индекс предмета.");
            return -1; 
        }
    }

    public void PrintStudentInfo()
    {
        Console.WriteLine($"ФИО: {LastName} {FirstName} {MiddleName}");
        Console.WriteLine($"Группа: {Group}");
        Console.WriteLine($"Возраст: {Age}");

        string[] subjects = { "Программирование", "Администрирование", "Дизайн" };

        for (int i = 0; i < Grades.Length; i++)
        {
             Console.WriteLine($"{subjects[i]}:");
             foreach (int grade in Grades[i]) {
                Console.Write($"{grade} ");
             }
             Console.WriteLine();
            Console.WriteLine($"Средний балл по {subjects[i]}: {GetAverageGrade(i).ToString("F2")}");
        }


    }
}

