using System;

namespace CalculadoraCPF
{
    class Program
    {
        static void Main(string[] args)
        {
        string cpfCliente, cpf9, cpf10;
        int contagem1=10, contagem2=11, resto=0, rs1=0, rs2=0;

            cpfCliente = "28591034813";
            cpf9 = cpfCliente.Substring(0,9);
        for(int i = 0; i < cpf9.Length; i++)
        {
            rs1 += int.Parse(cpf9[i].ToString())*contagem1;
            contagem1--;
        }
            resto = rs1 % 11;
        if(resto < 2)
            cpf10 = cpf9+0;
        else
            cpf10 = cpf9 + (11-resto);

        
        }
    }
}
