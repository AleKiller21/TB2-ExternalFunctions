import java.lang.System;

public class Bin2Dec {
    public static void main(String[] args) {
        System.out.print(BinToDecimal("11110001100000"));
    }

    public static int BinToDecimal(String bin) {
        int value = 0;
        int counter = 1;
        for(int i = bin.length() - 1; i >= 0; i--) {
            
            if(i == bin.length() - 1) {
                if(bin.charAt(i) == '1') value = 1;
                counter *= 2;
                continue;
            }
            if(bin.charAt(i) == '1') value += counter;
            counter *= 2;
        }

        return value;
    }
}