import java.util.Scanner;
public class GrassSeed{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        String cost = sc.next();
        double c = Double.parseDouble(cost);
        int l = sc.nextInt();
        double sum = 0;
        for(int i=0;i<l;i++){
            String x1 = sc.next();
            double x2 = Double.parseDouble(x1); 
            String y1 = sc.next();
            double y2 = Double.parseDouble(y1);
            sum = sum + x2 * y2 * c;
        }
        System.out.printf( "%.7f %n", sum);
    }
}