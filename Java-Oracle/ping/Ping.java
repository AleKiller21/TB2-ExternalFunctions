import java.io.IOException;
import java.lang.System;
import java.net.Socket;
import java.net.InetSocketAddress;

public class Ping {
    public static void main(String[] args) {
        System.out.println(Calculate("localhost"));
    }

    public static int Calculate(String ip) {
        try {
            new Socket().connect(new InetSocketAddress(ip, 80), 5000);
            return 1;
        }
        catch(IOException e) {
            return 0;
        }
    }
}