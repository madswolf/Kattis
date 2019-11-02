import java.util.Scanner;
public class Planina{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        int x = sc.nextInt();
        int e = (int) Math.pow(2,x);
        e = e+1;
        e = (int) Math.pow(e,2);
        System.out.print(e);
    }

}

