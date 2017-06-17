import java.lang.System;

public class Trim {
    public static void main(String[] args) {
        System.out.println(Calculate("aaaaolacshhhhaa", "b"));
    }
    public static String Calculate(String value, String character) {
        int i = 0;
        for(; i < value.length(); i++) {
            if(value.charAt(i) != character.charAt(0)) break;
        }

        value = value.substring(i);
        for(i = value.length() - 1; i >= 0; i--) {
            if(value.charAt(i) != character.charAt(0)) break;
        }

        return value.substring(0, i + 1);
    }
}