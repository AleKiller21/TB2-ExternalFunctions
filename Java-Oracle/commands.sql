
-------------------------------------------------- LOADING -------------------------------------------------

CREATE DIRECTORY jdir AS 'C:\Users\alefe\Unitec\15 Trimestre (XV)\Teoria Base Datos II\Proyectos\Proyecto 3\Java-Oracle\class_directory';

loadjava -user system/Persia1995 Bin2Dec.class
loadjava -user system/Persia1995 C2F.class
loadjava -user system/Persia1995 CompareString.class
loadjava -user system/Persia1995 Dec2Bin.class
loadjava -user system/Persia1995 Dec2Hex.class
loadjava -user system/Persia1995 F2C.class
loadjava -user system/Persia1995 Factorial.class
loadjava -user system/Persia1995 Hex2Dec.class
loadjava -user system/Persia1995 Ping.class
loadjava -user system/Persia1995 PMT.class
loadjava -user system/Persia1995 Repeat.class
loadjava -user system/Persia1995 Trim.class


-------------------------------------------------- PUBLISHING -------------------------------------------------

CREATE OR REPLACE FUNCTION convert_binary_to_decimal(bin VARCHAR2) RETURN NUMBER
AS LANGUAGE JAVA
NAME 'Bin2Dec.BinToDecimal(java.lang.String) return java.lang.String';

CREATE OR REPLACE FUNCTION celcius_to_fahrenheit(celcius NUMBER) RETURN NUMBER
AS LANGUAGE JAVA
NAME 'C2F.ConvertCelciusToFahrenheit(double) return double';

CREATE OR REPLACE FUNCTION compare_string(val1 VARCHAR2, val2 VARCHAR2) RETURN VARCHAR2
AS LANGUAGE JAVA
NAME 'CompareString.Calculate(java.lang.String, java.lang.String) return java.lang.String';

CREATE OR REPLACE FUNCTION decimal_to_binary(num NUMBER) RETURN VARCHAR2
AS LANGUAGE JAVA
NAME 'Dec2Bin.DecToBin(int) return java.lang.String';

CREATE OR REPLACE FUNCTION decimal_to_hexadecimal(dec NUMBER) RETURN VARCHAR2
AS LANGUAGE JAVA
NAME 'Dec2Hex.Calculate(int) return java.lang.String';

CREATE OR REPLACE FUNCTION fahrenheit_to_celcius(fahrenheit NUMBER) RETURN NUMBER
AS LANGUAGE JAVA
NAME 'F2C.Calculate(double) return double';

CREATE OR REPLACE FUNCTION hexadecimal_to_decimal(num VARCHAR2) RETURN NUMBER
AS LANGUAGE JAVA
NAME 'Hex2Dec.Calculate(java.lang.String) return int';

CREATE OR REPLACE FUNCTION ping(celcius VARCHAR2) RETURN NUMBER
AS LANGUAGE JAVA
NAME 'Ping.Calculate(java.lang.String) return int';
BEGIN
dbms_java.grant_permission( 'SYSTEM', 'SYS:java.net.SocketPermission', 'www.google.com', 'resolve' );
dbms_java.grant_permission( 'SYSTEM', 'SYS:java.net.SocketPermission', '216.58.219.164:80', 'connect,resolve' );
END;

CREATE OR REPLACE FUNCTION pmt(annualInterestRate NUMBER, periods NUMBER, loan NUMBER) RETURN NUMBER
AS LANGUAGE JAVA
NAME 'PMT.Calculate(double, int, double) return double';

CREATE OR REPLACE FUNCTION trim(value VARCHAR2, character VARCHAR2) RETURN VARCHAR2
AS LANGUAGE JAVA
NAME 'Trim.Calculate(java.lang.String, java.lang.String) return java.lang.String';

CREATE OR REPLACE FUNCTION repeat_word(value VARCHAR2, n NUMBER) RETURN VARCHAR2
AS LANGUAGE JAVA
NAME 'Repeat.Calculate(java.lang.String, int) return java.lang.String';

CREATE OR REPLACE FUNCTION factorial(num NUMBER) RETURN NUMBER
AS LANGUAGE JAVA
NAME 'Factorial.Calculate(int) return int';