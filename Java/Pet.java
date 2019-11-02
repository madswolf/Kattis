import java.util.Scanner;
import java.util.Arrays;
public class Pet{
    public static void main (String[] args){
        Scanner sc = new Scanner(System.in);
        int[] contestants = new int[5];
        for(int i=0;i<5;i++){
            contestants[i] = sc.nextInt() + sc.nextInt() + sc.nextInt() + sc.nextInt();
        }
        int max = contestants[0];
        int winner = 1;
        for (int t = 1; t < contestants.length; t++) {
            if (contestants[t] > max) {
                max = contestants[t]; 
                winner = t+1;
            }
        }
        System.out.print(winner + " " + max);
    }
}