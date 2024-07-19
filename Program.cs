string nomeDoHeroi = "Caio";
int experienciaDoHeroi = 100000;

switch (experienciaDoHeroi)
    {
        case <= 1000:

            Console.WriteLine($"O Herói de nome {nomeDoHeroi} está no nível Ferro");
            break;

        case >= 1001 and (<= 2000):

            Console.WriteLine($"O Herói de nome {nomeDoHeroi} está no nível Bronze");
            break;
        
        case >= 2001 and (<= 5000):

            Console.WriteLine($"O Herói de nomke {nomeDoHeroi} está no nível Prata");
            break;

        case >= 5001 and (<= 7000):

            Console.WriteLine($"O Herói de nome {nomeDoHeroi} está no nível Ouro");
            break;

        case >= 7001 and (<= 8000):

            Console.WriteLine($"O Herói de nome {nomeDoHeroi} está no nível Platina");
            break;

        case >= 8001 and (<= 9000):

            Console.WriteLine($"O Herói de nome {nomeDoHeroi} está no nível Ascendente");
            break;

        case >= 9001 and (<= 10000):

            Console.WriteLine($"O Herói de nome {nomeDoHeroi} está no nível Imortal");
            break;

        case >= 10001:

            Console.WriteLine($"O Herói de nome {nomeDoHeroi} está no nível Radiante");
            break;


    }

