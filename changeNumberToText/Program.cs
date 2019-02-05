using System;

class Program
{

    static void Main()
    {
        // TODO : keiskite FROM..TO skaicius pagal tai kiek spesite padaryt uzduociu. (-19...19, -99..99, ir tt.)
        // min skaicius 
        const int FROM_NUMBER = -99;
        // max skaicius 
        const int TO_NUMBER = 99;

        string inputString = "";
        int inputNumber = 0;

        Console.Write("Sveiki!");
        while (inputString != " ")
        {
            Console.Write("\n(Enter SPACE to exit.)\nIveskite skaiciu:");
            inputString = Console.ReadLine();
            if (checkIfGoodNumber(inputString))
            {
                Console.WriteLine("Skaicius teisingas!");

                inputNumber = Convert.ToInt32(inputString);
                if (checkIfNumberInRange(FROM_NUMBER, TO_NUMBER, inputNumber))
                {
                    Console.WriteLine("Skaicius {0} zodziais: {1}", inputNumber, changeNumberToText(inputNumber));
                }
                else
                {
                    Console.WriteLine("Blogas skaicius {0}, prasau ivesti skaiciu reziuose: {1}..{2}", inputString, FROM_NUMBER, TO_NUMBER);
                }
            }
            else
            {
                Console.WriteLine("Ivesti duomenys:{0} nera skaicius!", inputString);
            }
        }

        Console.WriteLine("\nAciu uz demesi, viso gero.");
        Console.ReadKey();
    }

    // bendra funkcija apjungti visom funkcijom kurias jus sukursit.
    static string changeNumberToText(int number)
    {
        // TODO : pakeiskite sita funkcija pagal savo poreiki. (tiek kiek skaiciu spesite apdorot.)
        if (number >= -9 && number <= 9)
        {
            return changeOnesToText(number);
        }
        else if (number <= -10 && number >= -19 || number >= 10 && number <= 19)
        {
            return changeTeensToText(number);
        }
        else if (number <= -20 && number >= -99 || number >= 20 && number <= 99)
        {
            return changeTensToText(number);
        }

        return " ";
    }

    // funkcija gauna string skaiciu, patikrina ar skaicius teisingu formatu. Pvz: "123", "-123" grazina true. "12a3", "1-23" grazina false.
    static bool checkIfGoodNumber(string dataToCheck)
    {
        for (int i = 0; i < dataToCheck.Length; i++)
        {
            char simbolis = dataToCheck[i];
            if (simbolis != '-' && simbolis != '1' && simbolis != '2' && simbolis != '3' && simbolis != '4' && simbolis != '5' && simbolis != '6' && simbolis != '7' && simbolis != '8' && simbolis != '9' && simbolis != '0')
            {
                return false;
            }
            else
            {
                for (i = 1; i < dataToCheck.Length; i++)
                {
                    char simbolis2 = dataToCheck[i];
                    if (simbolis2 != '1' && simbolis2 != '2' && simbolis2 != '3' && simbolis2 != '4' && simbolis2 != '5' && simbolis2 != '6' && simbolis2 != '7' && simbolis2 != '8' && simbolis2 != '9' && simbolis2 != '0')
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }//geresnei apsaugai reiketu pratesti
                return true;
            }
        }
        return false;
    }
    // funkcija gauna true jei skaicius checkNumber yar tarp fromNumber ir toNumber (imtinai)
    private static bool checkIfNumberInRange(int fromNumber, int toNumber, int checkNumber)
    {
        if (checkNumber >= fromNumber && checkNumber <= toNumber)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    // funkcija gauna int skaiciu, pakeicia ji i string teksta kuri zodziais nusako skaiciu. PVZ: -1684542 turi grazint - "minus vienas milijonas sesi simtai astuoniasdesimt keturi tukstanciai penki simtai keturiasdiasimt du"
    static string desimtys(int number)
    {
        string skaiciusZodziais = "";
        switch (number)
        {
            case 2:
                skaiciusZodziais = "dvidesimt";
                break;
            case 3:
                skaiciusZodziais = "trisdesimt";
                break;
            case 4:
                skaiciusZodziais = "keturiasdesimt";
                break;
            case 5:
                skaiciusZodziais = "penkiasdesimt";
                break;
            case 6:
                skaiciusZodziais = "sesiasdesimt";
                break;
            case 7:
                skaiciusZodziais = "septyniasdesimt";
                break;
            case 8:
                skaiciusZodziais = "astuoniasdesimt";
                break;
            case 9:
                skaiciusZodziais = "devyniasdesimt";
                break;
        }
        return skaiciusZodziais;
    }
    static string changeOnesToText(int number)
    {
        string skaiciusZodziais = "";
        char minusas = ' ';
        string yraMinusas = "";
        int naujasSkaicius = 0;
        string skaicius = Convert.ToString(number);

        for (int i = 0; i < skaicius.Length; i++)
        {
            minusas = skaicius[i];
            if (minusas == '-')
            {
                break;
            }
        }
        if (minusas == '-')
        {
            naujasSkaicius = number - number * 2;
            yraMinusas = "minus ";
            if (naujasSkaicius == 1)
            {
                skaiciusZodziais = "vienas";
            }
            if (naujasSkaicius == 2)
            {
                skaiciusZodziais = "du";
            }
            if (naujasSkaicius == 3)
            {
                skaiciusZodziais = "trys";
            }
            if (naujasSkaicius == 4)
            {
                skaiciusZodziais = "keturi";
            }
            if (naujasSkaicius == 5)
            {
                skaiciusZodziais = "penki";
            }
            if (naujasSkaicius == 6)
            {
                skaiciusZodziais = "sesi";
            }
            if (naujasSkaicius == 7)
            {
                skaiciusZodziais = "septyni";
            }
            if (naujasSkaicius == 8)
            {
                skaiciusZodziais = "astuoni";
            }
            if (naujasSkaicius == 9)
            {
                skaiciusZodziais = "devyni";
            }
        }
        else
        {
            switch (number)
            {
                case 1:
                    skaiciusZodziais = "vienas";
                    break;
                case 2:
                    skaiciusZodziais = "du";
                    break;
                case 3:
                    skaiciusZodziais = "trys";
                    break;
                case 4:
                    skaiciusZodziais = "keturi";
                    break;
                case 5:
                    skaiciusZodziais = "penki";
                    break;
                case 6:
                    skaiciusZodziais = "sesi";
                    break;
                case 7:
                    skaiciusZodziais = "septyni";
                    break;
                case 8:
                    skaiciusZodziais = "astuoni";
                    break;
                case 9:
                    skaiciusZodziais = "devyni";
                    break;
                case 0:
                    skaiciusZodziais = "nulis";
                    break;
            }
        }
        return yraMinusas + skaiciusZodziais;
    }
    static string changeTeensToText(int number)
    {
        string skaiciusZodziais = "";
        char minusas = ' ';
        string yraMinusas = "";
        int naujasSkaicius = 0;
        string skaicius = Convert.ToString(number);
        for (int i = 0; i < skaicius.Length; i++)
        {
            minusas = skaicius[i];
            if (minusas == '-')
            {
                break;
            }
        }
        if (minusas == '-')
        {
            naujasSkaicius = number - number * 2;
            yraMinusas = "minus ";
            if (naujasSkaicius == 10)
            {
                skaiciusZodziais = "desimt";
            }
            if (naujasSkaicius == 11)
            {
                skaiciusZodziais = "vienuolika";
            }
            if (naujasSkaicius == 12)
            {
                skaiciusZodziais = "dvylika";
            }
            if (naujasSkaicius == 13)
            {
                skaiciusZodziais = "trylika";
            }
            if (naujasSkaicius == 14)
            {
                skaiciusZodziais = "keturiolika";
            }
            if (naujasSkaicius == 15)
            {
                skaiciusZodziais = "penkiolika";
            }
            if (naujasSkaicius == 16)
            {
                skaiciusZodziais = "sesiolika";
            }
            if (naujasSkaicius == 17)
            {
                skaiciusZodziais = "septyniolika";
            }
            if (naujasSkaicius == 18)
            {
                skaiciusZodziais = "astuoniolika";
            }
            if (naujasSkaicius == 19)
            {
                skaiciusZodziais = "devyniolika";
            }
        }
        else
        {
            switch (number)
            {
                case 11:
                    skaiciusZodziais = "vienuolika";
                    break;
                case 12:
                    skaiciusZodziais = "dvylika";
                    break;
                case 13:
                    skaiciusZodziais = "trylika";
                    break;
                case 14:
                    skaiciusZodziais = "keturiolika";
                    break;
                case 15:
                    skaiciusZodziais = "penkiolika";
                    break;
                case 16:
                    skaiciusZodziais = "sesiolika";
                    break;
                case 17:
                    skaiciusZodziais = "septyniolika";
                    break;
                case 18:
                    skaiciusZodziais = "astuoniolika";
                    break;
                case 19:
                    skaiciusZodziais = "devyniolika";
                    break;
                case 10:
                    skaiciusZodziais = "desimt";
                    break;
            }
        }
        return yraMinusas + skaiciusZodziais;
    }

    static string changeTensToText(int number)
    {
        char minusas = ' ';
        string yraMinusas = "";
        int naujasSkaicius = 0;
        string skaicius = Convert.ToString(number);

        for (int i = 0; i < skaicius.Length; i++)
        {
            minusas = skaicius[i];
            if (minusas == '-')
            {
                break;
            }
        }
        if (minusas == '-')
        {
            naujasSkaicius = number - number * 2;
            yraMinusas = "minus ";
            string keiciamSimbolius = Convert.ToString(naujasSkaicius);
            for (int i = 0; i < keiciamSimbolius.Length; i++)
            {
                char pirmasSimbolis = keiciamSimbolius[i];
                if (pirmasSimbolis > '1')
                {
                    int TempNum1 = Convert.ToInt32(Char.GetNumericValue(pirmasSimbolis));
                    for (i = 1; i < keiciamSimbolius.Length; i++)
                    {
                        char antrasSimbolis = keiciamSimbolius[i];
                        if (antrasSimbolis == '0')
                        {
                            return yraMinusas + desimtys(TempNum1);
                        }
                        else if (antrasSimbolis > '0')
                        {
                            int TempNum2 = Convert.ToInt32(Char.GetNumericValue(antrasSimbolis));
                            return yraMinusas + desimtys(TempNum1) + " " + changeOnesToText(TempNum2);
                        }
                    }
                }
            }
        }
        else
        {
            string keiciamSimbolius = Convert.ToString(number);
            for (int i = 0; i < keiciamSimbolius.Length; i++)
            {
                char pirmasSimbolis = keiciamSimbolius[i];
                if (pirmasSimbolis > '1')
                {
                    int TempNum1 = Convert.ToInt32(Char.GetNumericValue(pirmasSimbolis));
                    for (i = 1; i < keiciamSimbolius.Length; i++)
                    {
                        char antrasSimbolis = keiciamSimbolius[i];
                        if (antrasSimbolis == '0')
                        {
                            return desimtys(TempNum1);
                        }
                        else if (antrasSimbolis > '0')
                        {
                            int TempNum2 = Convert.ToInt32(Char.GetNumericValue(antrasSimbolis));
                            return desimtys(TempNum1) + " " + changeOnesToText(TempNum2);
                        }
                    }
                }
            }
        }
        return "";

    }

    // TODO : sukurti funkcija kuri grazina skaiciu -99...99 zodziais - changeTensToText

    // TODO : sukurti funkcija kuri grazina skaiciu -999...999 zodziais - changeHundredsToText

    // TODO : sukurti funkcija kuri grazina skaiciu -9999...9999 zodziais - changeThousandsToText

    // TODO : sukurti funkcija kuri grazina skaiciu -9999999...9999999 zodziais - changeMillionsToText

    // TODO : sukurti funkcija kuri grazina skaiciu -9999999999...9999999999 zodziais - changeBilllionsToText



    //Skaiciai zodziais:  
    // "minus"; 
    // "nulis", "vienas", "du", "trys", "keturi", "penki", "sesi", "septyni", "astuoni", "devyni"; 
    // "desimt", "vienualika", "dvylika", "trylika", "keturiolika", "penkiolika", "sesiolika", "septyniolika", "astuoniolika", "devyniolika"; 
    // "dvidesimt", "trisdesimt", "keturiasdesimt", "penkiasdesimt", "sesiasdesimt", "septyniasdesimt", "astuoniasdesimt", "devyniasdesimt"; 
    // "simtas", "tukstantis", "milijonas", "milijardas"; 
    // "simtai", "tukstanciai", "milijonai", "milijardai"; 
    // "simtu", "tukstanciu", "milijonu", "milijardu"; 
}