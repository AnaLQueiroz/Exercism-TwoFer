using System;

public static class TwoFer
{
    // In order to get the tests running, first you need to make sure the Speak method 
    // can be called both without any arguments and also by passing one string argument.

    // No teste não está sendo enviado nenhum parametro
    public static string Speak()
    {
        string msg = "One for you, one for me.";
        return msg;
    }


    // No caso desse teste, é enviado dois nomes distintos para cada teste como parametro
    public static string Speak(string Name)
    {
        string msg = "";
        
        int valor = Name.Length;
        // Conferindo se na string passada para a função tem ao menos 1 letra
        if (valor == 0)
        {
            msg = "One for you, one for me.";
           
        }
        else
        {  // Mensagem utilizando a técnica de interpolação.
            msg = $"One for {Name}, one for me.";
        }
        return msg;
    }
}
