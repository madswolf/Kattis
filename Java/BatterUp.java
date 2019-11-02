import java.util.Scanner;
public class BatterUp{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        double N = sc.nextInt();
        double total = 0;
        double y = N;
        for(int i = 0;i<N;i++){
             int x = sc.nextInt();
            if(x>=0){
                total = total + x;
            } else{
                y = y - 1;
            }
        }
        double d = total/y;
        System.out.print(d);
    }
}
