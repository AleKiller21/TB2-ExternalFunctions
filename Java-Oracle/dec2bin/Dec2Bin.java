import java.lang.System;

public class Dec2Bin {
    public static void main(String[] args) {
        System.out.println(DecToBin(0));
    }

    public static String DecToBin(int number) {
        String bin = "";
        String answer = "";
        if (number == 0) return "0";
        while(number > 0) {
            if(number % 2 != 0) bin = bin.concat("1");
            else bin = bin.concat("0");
            number /= 2;
        }
        for(int i = bin.length() - 1; i >= 0; i--) {
            answer = answer.concat(bin.charAt(i) + "");
        }

        return answer;
    }
}