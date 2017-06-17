import java.lang.System;

public class F2C {
    public static void main(String[] args) {
        System.out.println(Calculate(48));
    }

    public static double Calculate(double fahrenheit) {
        return (fahrenheit - 32) * 5/9;
    }
}