import java.util.Scanner;
import java.util.ArrayList;
import java.util.List;

class LastFactorialDigit {

    public static void main(String[] args){

        List<String> lastDigit = new ArrayList<>();
        int factorial = 1;
        Scanner sc = new Scanner(System.in);

        for(int i=1;i<=10;i++){
            factorial *= i;
            String s = Integer.toString(factorial);
            Character last = s.charAt(s.length()-1);
            lastDigit.add(last.toString());
        }
        
        int y=sc.nextInt();
        for(int i=0;i<y;i++){
            System.out.println(lastDigit.get(sc.nextInt()-1)); 
        }
        

    }

}