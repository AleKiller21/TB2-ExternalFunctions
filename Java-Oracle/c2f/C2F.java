import java.lang.System;

public class C2F {
    public static void main(String[] args) {
        System.out.println(ConvertCelciusToFahrenheit(0));
    }

    public static double ConvertCelciusToFahrenheit(double celcius) {
        return celcius * 9/5 + 32;
    }
}