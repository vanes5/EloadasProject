using System;

namespace EloadasProject
{
    public class Eloadas
    {
        private bool[,] foglalasok;

        public Eloadas(int sorokSzama, int helyekSzama)
        {
            if (sorokSzama <= 0)
            {
                throw new ArgumentException(String.Format("Nagyobbnak kell lennie 0-nál", sorokSzama),
                                      "sorokSzama");
            }
            else if (helyekSzama <= 0)
            {
                throw new ArgumentException(String.Format("Nagyobbnak kell lennie 0-nál", helyekSzama),
                                     "helyekSzama");
            }
            else
            {
                this.foglalasok = new bool[sorokSzama, helyekSzama];

            }
        }

        public void Lefoglal()
        {
            for (int i = 0; i < foglalasok.GetLength(0); i++)
            {
                for (int j = 0; j < foglalasok.GetLength(1); j++)
                {
                    var hely = foglalasok[i, j];

                    if (!hely)
                    {
                        foglalasok[i, j] = true;
                        return;
                    }
                }
            }
        }

        public int SzabadHelyek
        {

            get {
                int db = 0;
                for (int i = 0; i < foglalasok.GetLength(0); i++)
                {
                    for (int j = 0; j < foglalasok.GetLength(1); j++)
                    {
                        var hely = foglalasok[i, j];

                        if (!hely)
                        {
                            db++;
                        
                        }
                    }
                }
                return  db;
            }

        }

        public bool Teli
        {
            get
            {
                for (int i = 0; i < foglalasok.GetLength(0); i++)
                {
                    for (int j = 0; j < foglalasok.GetLength(1); j++)
                    {
                        var hely = foglalasok[i, j];

                        if (!hely)
                        {
                            return false;

                        }
                    }
                }
                return true;
            }
        }

        public bool Foglalt(int sor, int hely)
        {
            if (sor <= 0 || hely <= 0)
            {
                throw new ArgumentException(String.Format("Nagyobbnak kell lennie 0-nál mindkét értéknek"));
            }
            if (foglalasok[sor-1,hely-1])
            {
                return true;
            }
            return false;
        }


    }
}
