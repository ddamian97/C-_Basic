using System;

namespace Mtrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m1 = new int[,]{{ 0, 1, 2, 3, 4 },
                          { 1, 1, 2, 3, 4},
                          { 2, 2, 2, 3, 4},
                          { 3, 3, 3, 3, 4},
                          { 4, 4, 4, 4, 4},
                           };




            int[,] m2;
 

            Program p1 = new Program();
            m2 = p1.MatrixOut(m1);



       

            Console.WriteLine(m2[0, 0]);
            Console.WriteLine(m2[0, 1]);
            Console.WriteLine(m2[1, 0]);
            Console.WriteLine(m2[1, 1]);

          


        }

        public int [,] MatrixOut(int [,] m1)
        {
            int g1 = 0; //  tworze zmienne, do ktorych bede sumowal poszczegolne elementy tablicy
            int y1 = 0;
            int b1 = 0;
            int o1 = 0;
            int[,] mOut = new int [2,2];
            for (int i = 0; i < m1.GetLength(0); i++)   //  tworze dwie petle przechodzace po kazdym elemencie tablicy
            {

                for (int j = 0; j < m1.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        if ((i + j) < m1.GetLength(1)-1)    // sprawdzam warunki (nigdy nie sumuje przekatnych)
                        {
                            //Console.WriteLine("green");
                            //Console.WriteLine(i + " "+j);


                            g1 += m1[i,j];
                        }
                        if ((i + j) > m1.GetLength(1)-1)
                        {
                            //Console.WriteLine("blue");
                            //Console.WriteLine(i + " "+j);
                            b1 += m1[i, j];

                        }
                    }
                    if (i > j)
                    {
                        if ((i + j) < m1.GetLength(1)-1)
                        {
                            //Console.WriteLine("yellow");
                            //Console.WriteLine(i + " "+j);
                            y1 += m1[i, j];
                        }
                        if ((i + j) > m1.GetLength(1)-1)
                        {
                            //Console.WriteLine("orange");
                            //Console.WriteLine(i + " "+j);
                            o1 += m1[i, j];
                        }
                    }

                }
            }



            mOut[0, 0] = g1;    //  do nowej macierzy wpisuje moje sumy
            mOut[0, 1] = b1;
            mOut[1, 0] = o1;
            mOut[1, 1] = y1;

            return mOut;
        }
    }
}
