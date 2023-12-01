namespace AdventOfCode.Day1;

public class CalibrationValues
{
    private string PathFile = "C:\\Users\\Usuário\\Documents\\projetos\\AdventOfCode-2023\\AdventOfCode\\Day1\\exemplo.txt";
    public string Conteudo {  get; set; }
    public string[] Lista {  get; set; }

    public CalibrationValues()
    {
        Conteudo = File.ReadAllText(PathFile);
        Lista = File.ReadAllLines(PathFile);
        EditarArquivoTxt();
    }

    public void EditarArquivoTxt()
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
}
