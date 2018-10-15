using System;

class Calculator {
    public static double calculateY(double x, double a, double b) {
        return Math.Asin(Math.Pow(x,a)) + Math.Acos(Math.Pow(x,a)); 
    }
}