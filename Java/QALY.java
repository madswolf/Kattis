import java.util.Scanner;

class QALY {
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        double QALY = 0;
        int n = sc.nextInt();
        for(int i=0;i<n;i++){
            double q = sc.nextDouble();
            double y = sc.nextDouble();

            QALY += q*y;
        }
        System.out.println(QALY);
    }
}