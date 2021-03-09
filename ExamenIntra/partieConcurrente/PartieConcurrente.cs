using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ExamenIntra.partieConcurrente
{
    
    class Syracuse
    {
        public long Iteration { get; set; }
        public void Next()
        {
            if (Iteration % 2 == 0)
                Iteration /= 2;
            else
                Iteration = Iteration * 3 + 1;
        }

    }
    class PartieConcurrente
    {
        Syracuse syracuse;
        private static readonly object lock1 = new object();
        public static void Start()
        {
            Syracuse r = new Syracuse();
            r.Iteration = 989_345_275_647;

            const int NB_THREADS = 5;
            Thread[] threads = new Thread[NB_THREADS];

            for (int i = 0; i < NB_THREADS; i++)
                threads[i] = new Thread(() => new PartieConcurrente(r).Run());

            Thread afficheur = new Thread(() => new PartieConcurrente(r).AfficherAttribut());
            afficheur.Start();

            foreach (Thread t in threads)
                t.Start();

            


            foreach (Thread t in threads)
                t.Join();
        }

        public PartieConcurrente(Syracuse r)
        {
            this.syracuse = r;
        }

        void Run()
        {
            for (int i = 0; i < 1000; i++)
            {
                lock (lock1)
                {
                    /*if ((i % 100) == 0)
                    {
                        Console.WriteLine(syracuse.Iteration);
                    }*/
                    syracuse.Next();
                    //Thread.Sleep(10);
                }
            }
        }

        void AfficherAttribut()
        {
            for(int i=0; i<=99;i++)
            {
                Console.WriteLine(syracuse.Iteration);
                Thread.Sleep(100);
            } 
            
        }
    }
}
