import java.util.Scanner;
class LicenseToLaunch{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
    int days = sc.nextInt();
    int bestDay = 0;
    int bestDayValue = sc.nextInt();
    for(int i = 1;i<days;i++){
        int x = sc.nextInt();
        if(x==bestDayValue){

        }else if(x<bestDayValue){
            bestDayValue = x;
            bestDay = i;
        }

    }
    System.out.println(bestDay);
    }
}