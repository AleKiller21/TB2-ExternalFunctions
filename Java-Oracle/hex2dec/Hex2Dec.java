import java.lang.System;

public class Hex2Dec {
    public static void main(String[] args) {
        System.out.println(Calculate("DF7444"));
    }

    public static int Calculate(String hex) {
        String bin = "";
        for(int i = 0; i < hex.length(); i++) {
            switch(hex.charAt(i)) {
                case '0':
                    bin = bin.concat("0000");
                    break;
                case '1':
                    bin = bin.concat("0001");
                    break;
                case '2':
                    bin = bin.concat("0010");
                    break;
                case '3':
                    bin = bin.concat("0011");
                    break;
                case '4':
                    bin = bin.concat("0100");
                    break;
                case '5':
                    bin = bin.concat("0101");
                    break;
                case '6':
                    bin = bin.concat("0110");
                    break;
                case '7':
                    bin = bin.concat("0111");
                    break;
                case '8':
                    bin = bin.concat("1000");
                    break;
                case '9':
                    bin = bin.concat("1001");
                    break;
                case 'A':
                    bin = bin.concat("1010");
                    break;
                case 'B':
                    bin = bin.concat("1011");
                    break;
                case 'C':
                    bin = bin.concat("1100");
                    break;
                case 'D':
                    bin = bin.concat("1101");
                    break;
                case 'E':
                    bin = bin.concat("1110");
                    break;
                case 'F':
                    bin = bin.concat("1111");
                    break;
            }
        }
        return BinToDecimal(bin);
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