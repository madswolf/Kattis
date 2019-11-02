import java.util.Scanner;

class Filip {
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        String a = sc.next();
        String b = sc.next();
        String aReverse = "";
        String bReverse = "";
        String result;

        for(int i =a.length()-1;i>=0;i--){
            aReverse += a.charAt(i);
        }
        for(int i =b.length()-1;i>=0;i--){
            bReverse += b.charAt(i);
        }
        
        int aReverseInt = Integer.parseInt(aReverse);
        int bReverseInt = Integer.parseInt(bReverse);
        
        if(aReverseInt>bReverseInt){
            result = aReverse;
        }else{
            result = bReverse;
        }
        System.out.println(result);
    }
}
