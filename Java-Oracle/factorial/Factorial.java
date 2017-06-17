import java.lang.System;

public class Factorial {
    public static void main(String[] args) {
        System.out.println(Calculate(7));
    }

    public static int Calculate(int number) {
        if(number == 0) return 1;

        int answer = 1;
        for(int i = 1; i < number; i++) {
            answer *= (i + 1);
        }

        return answer;
    }
}