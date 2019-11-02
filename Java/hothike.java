import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.Iterator;

public class hothike {
    public static void main(String[] args) throws Exception {
        BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
        int count = Integer.parseInt(in.readLine());
        Iterator<Integer> temperatures = Arrays.stream(in.readLine()
            .split(" "))
            .map(s -> Integer.parseInt(s))
            .iterator();

        int twodaysback = temperatures.next();
        int onedaysback = temperatures.next();
        
        int currentLowestMax = Integer.MAX_VALUE;
        int currentLowestMaxDay = 0;

        for(int i = 0 ; i < count-2 ; i++){
            int currentday = temperatures.next();
            int currentMax = Math.max(currentday, twodaysback);
            
            if(currentMax < currentLowestMax){
                currentLowestMax = currentMax;
                currentLowestMaxDay = i + 1;
            }

            twodaysback = onedaysback;
            onedaysback = currentday;
        }

        System.out.println(currentLowestMaxDay + " " + currentLowestMax);
    }
}