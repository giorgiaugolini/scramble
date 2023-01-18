using System;
using System.Collections.Generic;

public static class PesoLettere
{
    public static int Pesa(string input)
    {
    int peso = 0;
        foreach (char lettera in input)
        {
            switch (lettera.ToString().ToLower())
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                case "l":
                case "n":
                case "r":
                case "s":
                case "t":
                    peso += 1;
                    break;
                case "d":
                case "g":
                    peso += 2;
                    break;
                case "b":
                case "c":
                case "m":
                case "p":
                    peso += 3;
                    break;
                case "f":
                case "h":
                case "v":
                case "w":
                case "y":
                    peso += 4;
                    break;
                case "k":
                    peso += 5;
                    break;
                case "j":
                case "x":
                    peso += 8;
                    break;
                case "q":
                case "z":
                    peso += 10;
                    break;
            }
        }
    return peso;
    }
}