import java.util.Scanner;
class IsItHalloween{
public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        String month = sc.next();
        int day = sc.nextInt();
        if(month.equals("OCT") && day == 31){
            System.out.println("yup");
        }else if(month.equals("DEC") && day == 25){
            System.out.println("yup");
        }else{
            System.out.println("nope");
        }
    }
}