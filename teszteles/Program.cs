using System.Diagnostics;
//1. feladat
int IntegerDivide(int szam, int oszto)
{
    Debug.Assert((szam % oszto == 0), $"{nameof(szam)} nem 0 és ez hibát fog eredményezni!");
    return szam % oszto;
}

int[] szamok = {3, 5, 8, 20, 43, 9, 56};

for (int i = 1; i < szamok.Length; i++)
{
    IntegerDivide(szamok[i], i);
}


//2. feladat
int szam1 = 5;
int szam2 = 4;

int result = szam1+szam2;

Debug.Assert(result < 10, "Az eredménynek 9-et kellett volna vissza adnia!");

