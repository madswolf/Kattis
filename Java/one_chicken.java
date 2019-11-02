import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

public class one_chicken{
    public static void main(String[] args)throws Exception{
        BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
        String[] numbers = in.readLine().split(" ");
        int x = Integer.parseInt(numbers[0]);
        int y = Integer.parseInt(numbers[1]);

        String pluralisation = "";
        
        if(Math.abs(x-y) > 1){
            pluralisation = "s";
        }

        if(x < y){
            System.out.println("Dr. Chaz will have " + (y-x) + " piece" + pluralisation + " of chicken left over!");
        }else{
            System.out.println("Dr. Chaz needs " + (x-y) + " more piece" + pluralisation + " of chicken!");
        } 
    }
}