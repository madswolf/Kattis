import java.util.Scanner;
public class Ladder{
    public static void main(String[] args){
     Scanner sc = new Scanner(System.in);
     int h = sc.nextInt();
     int v = sc.nextInt();
     double l = (int) h/Math.sin(Math.toRadians(v));
     l = Math.ceil(l); //brug Math.metodeher -> Math.ceil(x)
     int y = (int) l;
     System.out.println(y);
    }
}