int numero, ctrl = 7;
int[] bin = new int[8];
Console.Write("Informe o valor para converter em binário: ");
numero = int.Parse(Console.ReadLine());

binario(numero);

for (ctrl = 0; ctrl < 8; ctrl++)
{
    Console.Write(bin[ctrl]);
}
int binario(int numero)
{
    if (numero > 0)
    {
        bin[ctrl] = numero % 2;
        ctrl--;
        return binario(numero / 2);
    }
    return 0;
}

