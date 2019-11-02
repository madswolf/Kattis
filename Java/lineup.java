import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

public class lineup{
    public static void main(String[] args)throws Exception{
        BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
        int count = Integer.parseInt(in.readLine());
        int order = 0;
        String output = "";
        String previousName = "";

        for(int i = 0 ; i < count ; i++){
            String currentName = in.readLine();

            if(!previousName.equals("")){
                int comparison = previousName.compareTo(currentName) < 0 ? -1 : 1;

                if(order != 0 && comparison != order){
                    output = "NEITHER";
                    break;
                }
                order = comparison;
            }
            previousName = currentName;
        }

        if(output.equals("")){
            output = order == -1 ? "INCREASING" : "DECREASING";
        }
        System.out.println(output);
    }
}