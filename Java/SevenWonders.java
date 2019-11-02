import java.util.Scanner;
public class SevenWonders{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        String s = sc.next();
        int t = 0;
        int c = 0;
        int g = 0;
        for (int i = 0; i < s.length(); i++){
            switch(s.charAt(i)){
                case 'T':
                t=t+1;
                break;

                case 'C':
                c=c+1;
                break;

                case'G':
                g=g+1;
                break;
            }
        }
        int point = t*t+c*c+g*g;
        while(t>0 && c>0 && g>0){
            point = point +7;
            t=t-1;
            c=c-1;
            g=g-1;
        }
        System.out.print(point);
    }
}

