using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CharInversion("Agilero"));    //  nie jestem pewny, czy dobrze zrozumialem polecenie, poniewaz przyklad   
                                                        //  byl rozwiazany inaczej



    }

    static String CharInversion(String sIn)
    {
        string sOut = "";
        string tmp2 = "";
        string tmp3 = "";
        for(int i=sIn.Length-1; i>=0; i--)  //  petla przechodze od ostatniego chara do pierwszego i dodaje do nowego stringa
        {
            sOut += sIn[i];
        }

       for(int i=0; i<sOut.Length; i++) //  petla zamieniajaca wszystkie litery na male
        {
            char ch1 = sOut[i];

            if(ch1>='A' && ch1 <= 'Z')  // sprawdzam czy znak jest mala litera
            {
                tmp3 += "" + (char)(sOut[i] + 32);
            }
            else
            {
                tmp3 += sOut[i];
            }
        }



        char tmp1 = (char)tmp3[0];  //  pierwszy znak przypisuje do nowego chara
        if(tmp1>='a' && tmp1<= 'z') //  sprawdzam po tablicy ASCII czy pierwszy znak jest mala litera
        {
            tmp2 += "" + (char)(tmp1 - 32);
        }
        else
        {
            tmp2 += "" + tmp1;
        }
        String sOut1 = "";
        for(int i=1; i<sOut.Length; i++)    // do nowej zmiennej przypisuje moj odwrocony String bez pierwszej litery
        {
            sOut1 += tmp3[i];
        }
        tmp2 += sOut1;  // do mojej duzej pierwszej litery dopisuje Stringa bez pierwszego znaku
        return tmp2;
    }


}