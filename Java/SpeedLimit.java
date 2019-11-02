import java.util.Scanner;
class SpeedLimit{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        int check = sc.nextInt();
        int lastY = 0;
        int total = 0;
        while(!(check == -1)){
            
            for(int i=0;i<check;i++){

                int x = sc.nextInt();
                int y = sc.nextInt();

                total += x*(y-lastY);
                lastY = y;

            }
            System.out.println(total + " miles");
            check = sc.nextInt();
            total = 0;
            lastY = 0;
        }
    }
}