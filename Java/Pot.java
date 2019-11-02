import java.util.Scanner;

public class Pot{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        double total = 0;
        while(sc.hasNext()){
            int x = sc.nextInt();
            int y = x/10;
            int z = x%10;
            
            total = total + Math.pow(y,z);
            
        }
        int sum = (int) Math.round(total);
        System.out.print(sum);
    }
}
