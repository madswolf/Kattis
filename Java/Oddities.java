import java.util.Scanner;
public class Oddities{
    public static void main (String[] args){
        Scanner sc = new Scanner(System.in);
        int N = sc.nextInt();
        for(int i=0;i<N;i++){
            int x = sc.nextInt();
            if(x%2==0){
                System.out.println(x + " is even");
            }else if(x%2==1 || x%2==-1){
                System.out.println(x + " is odd");
            }
        }
    }
}