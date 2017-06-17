import java.lang.System;

public class Dec2Hex {
    public static void main(String[] args) {
        System.out.println(Calculate(455874112));
    }

    //FALLA
    public static String Calculate(int dec) {
        String bin = DecToBin(dec);
        String answer = "";
        String padLeft = "";
        String finalBin = "";
        int counter = 0;

        for(int i = bin.length() - 1; i >= 0; i--) {
            counter++;
            if(counter == 4) counter = 0;
        }
        if(counter != 0) {
            for(int i = 4; i > counter; i--) {
                padLeft = padLeft.concat("0");
            }
        }

        finalBin = padLeft + bin;
        for(int i = 0; i < finalBin.length(); i += 4) {
            String HexDigit = "";
            for(int x = 0; x < 4; x++) {
                if(x+i >= finalBin.length()) break;
                HexDigit = HexDigit.concat(finalBin.charAt(i + x) + "");
            }
            answer = answer.concat(GetHexDigit(HexDigit));
        }

        return answer;
    }

    public static String GetHexDigit(String bin) {
        switch(bin) {
                case "0000":
                    return "0";
                case "0001":
                    return "1";
                case "0010":
                    return "2";
                case "0011":
                    return "3";
                case "0100":
                    return "4";
                case "0101":
                    return "5";
                case "0110":
                    return "6";
                case "0111":
                    return "7";
                case "1000":
                    return "8";
                case "1001":
                    return "9";
                case "1010":
                    return "A";
                case "1011":
                    return "B";
                case "1100":
                    return "C";
                case "1101":
                    return "D";
                case "1110":
                    return "E";
                case "1111":
                    return "F";
                default:
                    return "";
            }
    }

    public static String DecToBin(int number) {
        String bin = "";
        String answer = "";
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