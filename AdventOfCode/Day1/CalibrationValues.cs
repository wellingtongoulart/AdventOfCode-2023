using System.Threading.Channels;

namespace AdventOfCode.Day1;

public class CalibrationValues
{
    private string PathFile { get; set; }
    public string Conteudo { get; set; }
    public string[] Lista { get; set; }
    public string[] Lista2 { get; set; }
    public Dictionary<string, int> NomeNumero { get; } = new Dictionary<string, int>
    {
        {"zero", 0 },
        {"one", 1 },
        {"two", 2 },
        {"three", 3 },
        {"four", 4 },
        {"five", 5 },
        {"six", 6 },
        {"seven", 7 },
        {"eight", 8 },
        {"nine", 9 },
    };

    public CalibrationValues(string pathFile)
    {
        PathFile = pathFile;
        Conteudo = File.ReadAllText(PathFile);
        Lista = File.ReadAllLines(PathFile);
        Lista2 = File.ReadAllLines(PathFile);
    }

    public void EditFileTxt()
    {
        if (Lista.Length > 1)
        {
            for (int i = 0; i < Lista.Length; i++)
            {
                Lista[i] += ",";
            }

            File.WriteAllLines(PathFile, Lista);
        }
    }

    public int CalibrationValue()
    {
        int sumNumbers = 0;

        foreach (string lista in Lista)
        {
            int firstNumber = -1;
            int lastNumber = -1;
            foreach (char caractere in lista)
            {
                if (char.IsDigit(caractere))
                {
                    if (firstNumber == -1)
                    {
                        firstNumber = int.Parse(caractere.ToString());
                    }

                    lastNumber = int.Parse(caractere.ToString());
                }
            }

            string finalNumber = String.Concat(firstNumber, lastNumber);
            sumNumbers += Convert.ToInt32(finalNumber);
        }

        return sumNumbers;
    }

    public int CalibrationValue(bool complex)
    {
        int sumNumbers = 0;

        for (int i = 0; i < Lista.Length; i++)
        {
            int firstNumber = -1;
            int lastNumber = -1;

            foreach (var item in NomeNumero)
            {
                Lista[i] = Lista[i].Replace(item.Key, item.Value.ToString());
            }

            foreach (char caractere in Lista[i])
            {
                if (char.IsDigit(caractere))
                {
                    if (firstNumber == -1)
                    {
                        firstNumber = int.Parse(caractere.ToString());
                    }

                    lastNumber = int.Parse(caractere.ToString());
                }
            }
            string finalNumber = String.Concat(firstNumber, lastNumber);
            sumNumbers += Convert.ToInt32(finalNumber);
            Console.WriteLine(Lista[i]);
            Console.WriteLine(finalNumber);
        }
        return sumNumbers;
    }

    public void teste()
    {
        int sumNumbers = 0;
        Console.WriteLine("lista ascendente");
        for (int i = 0; i < Lista.Length; i++)
        {
            int firstNumber = -1;
            int lastNumber = -1;

            foreach (var item in NomeNumero)
            {
                Lista[i] = Lista[i].Replace(item.Key, item.Value.ToString());
            }

            foreach (char caractere in Lista[i])
            {
                if (char.IsDigit(caractere))
                {
                    if (firstNumber == -1)
                    {
                        firstNumber = int.Parse(caractere.ToString());
                    }

                    lastNumber = int.Parse(caractere.ToString());
                }
            }
            string finalNumber = String.Concat(firstNumber, lastNumber);
            sumNumbers += Convert.ToInt32(finalNumber);


            Console.WriteLine(Lista[i]);
            Console.WriteLine(finalNumber);
        }
        Console.WriteLine(sumNumbers.ToString() + "  Soma final");
    }

    public void teste2()
    {
        Console.WriteLine("\nlista descendente");
        int sumNumbers = 0;
        var nomeNumero2 = NomeNumero.OrderByDescending(item => item.Value).ToDictionary(x => x.Key, x => x.Value);

        for (int i = 0; i < Lista2.Length; i++)
        {
            int firstNumber = -1;
            int lastNumber = -1;

            foreach (var item2 in nomeNumero2)
            {
                Lista2[i] = Lista2[i].Replace(item2.Key, item2.Value.ToString());
            }


            foreach (char caractere in Lista2[i])
            {
                if (char.IsDigit(caractere))
                {
                    if (firstNumber == -1)
                    {
                        firstNumber = int.Parse(caractere.ToString());
                    }

                    lastNumber = int.Parse(caractere.ToString());
                }
            }
            string finalNumber = String.Concat(firstNumber, lastNumber);
            sumNumbers += Convert.ToInt32(finalNumber);


            Console.WriteLine(Lista2[i]);
            Console.WriteLine(finalNumber);
        }
        Console.WriteLine(sumNumbers.ToString() + "  Soma final");
    }

    public void teste3()
    {
        int sumNumbers = 0;

        for (int i = 0; i <= Lista.Length; i++) 
        {
            int firstNumber = -1;
            int lastNumber = -1;
            string concat = "";
            while (concat.Length < 0)
            {

            }
            foreach (char caractere in Lista[i])
            {
                if (!char.IsDigit(caractere)) 
                {
                    concat = String.Concat(concat, caractere.ToString());
                    if (NomeNumero.ContainsKey(concat))
                    {
                        int novo = NomeNumero.GetValueOrDefault(concat);
                        var lixo = Lista[i].Contains(concat);
                        Lista[i] = Lista[i].Replace(concat, novo.ToString());
                        //concat = concat.remove
                        //concat = "";
                    } 
                } else
                {
                    if (firstNumber == -1)
                    {
                        firstNumber = int.Parse(caractere.ToString());
                    }

                    lastNumber = int.Parse(caractere.ToString());
                }
            }

            // if (Lista[i].Contains(concat))

            Console.WriteLine(Lista[i].ToString());
            Console.WriteLine(concat+"                     sabao");
        }
    }

    public void sanfona()
    {

    }
}
