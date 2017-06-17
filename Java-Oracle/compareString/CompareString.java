import java.lang.System;

public class CompareString {
    public static void main(String[] args) {
        System.out.println(Calculate("g", "xx"));
    }

    public static String Calculate(String val1, String val2) {
        if(val1.length() < val2.length()) return "-1";
        else if(val1.length() == val2.length()) return "0";
        else return "1";
    }
}