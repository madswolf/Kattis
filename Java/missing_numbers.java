import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

public class missing_numbers{
    public static void main(String[] args)throws Exception{
        BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
        int count = Integer.parseInt(in.readLine());
        int expected = 1;
        List<Integer> missing_numbers = new ArrayList<>();

        for(int i = 0; i < count ; i++){
            int number = Integer.parseInt(in.readLine());
            for(int x = expected ; x < number ; x++){
                missing_numbers.add(x);
            }
            expected = number + 1;
        }

        if(missing_numbers.isEmpty()){
            System.out.println("good job");
        }else{
            for(int number : missing_numbers){
                System.out.println(number);
            }
        }
    }
}