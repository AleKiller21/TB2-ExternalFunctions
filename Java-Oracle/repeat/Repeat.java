import java.lang.System;

public class Repeat {
    public static void main(String[] args) {
        System.out.println(Calculate("jack", 3));
    }

    public static String Calculate(String value, int n) {
        String answer = "";
        for(int i = 0; i < n; i++) {
            answer += value;
        }

        return answer;
    }
}