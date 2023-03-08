string texto;
int contvogal= 0, contconsoante = 0;
string vogal = "aeiouAEIOU";
string consoante = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWYZ";

Console.WriteLine("Digite o texto que sera usado: ");
texto = Console.ReadLine();

Console.WriteLine("O tamanho do texto é " + texto.Length);

for (int i = 0; i < texto.Length; i++)
{
    if (vogal.Contains(texto[i])){
        contvogal += 1;
    }
    if (consoante.Contains(texto[i]))
    {
        contconsoante += 1;
    }
}
Console.WriteLine("O texto apresenta :" + contvogal + " vogais e " + contconsoante + " consoantes");
for (int i = 0; i < texto.Length; i++)
{
    if (i % 2 == 0)
    {
        string v = texto[i].ToString().ToUpper();
        Console.Write(v);
    }
    else
    {
        string v = texto[i].ToString().ToLower();
        Console.Write(v);
    }
}
Console.WriteLine();
for (int i = texto.Length - 1; i >= 0; i--)
{
    Console.Write(texto[i]);
}
Console.WriteLine();