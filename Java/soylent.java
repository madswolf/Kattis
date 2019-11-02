import java.io.BufferedReader;
import java.io.InputStreamReader;

public class soylent{
    public static void main(String[] args)throws Exception{
        BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
        int count = Integer.parseInt(in.readLine());
        
        for(int i = 0 ; i < count ; i++){
            int calories = Integer.parseInt(in.readLine());
            int bottles = (int) Math.ceil(calories/400d);
            System.out.println(bottles);
        }
    }
}