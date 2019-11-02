import java.util.Scanner;
public class Trik{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        String s = sc.next();
        int x = 1;
        int y = 0;
        int z = 0;
        for (int i = 0; i < s.length(); i++){
            switch(s.charAt(i)){
                case 'A':
                int q1 = x;
                int p1 = y;
                x=p1;
                y=q1;
                break;

                case 'B':
                int q2 = y;
                int p2 = z;
                y=p2;
                z=q2;
                break;

                case'C':
                int q3 = x;
                int p3 = z;
                x=p3;
                z=q3;
                break;
            }

        }
        if(x==1){
            System.out.print(1);
        }else if(y==1){
            System.out.print(2);
        }else {
            System.out.print(3);
        }
    }
}
