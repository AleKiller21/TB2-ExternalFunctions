import java.lang.*;

public class PMT {
    public static void main(String[] args) {
        System.out.println(Calculate(9, 56, 55000));
    }

    public static double Calculate(double annualInterestRate, int periods, double loan) {
        double R = (annualInterestRate / 100) / 12;
        return (loan * R) / (1 - Math.pow((1 + R), (-periods)));
    }
}