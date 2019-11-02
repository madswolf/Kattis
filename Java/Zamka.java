import java.util.StringTokenizer;
import java.io.BufferedReader;
import java.io.BufferedOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.io.OutputStream;

public class Zamka{
    
    public static void main(String[] args){
        
        Kattio io = new Kattio(System.in);
        
        int l = io.getInt();
        int d = io.getInt();
        int x = io.getInt();
        int n = d;
        int m = l;
        
        for(int i = l;i<=d;i++){

            String s = Integer.toString(i);
            //io.println(s);
            int sumOfDigits = 0;

            for(int j = 0;j<s.length();j++){

                sumOfDigits += Integer.parseInt(String.valueOf(s.charAt(j)));

            }

            if(sumOfDigits==x){
            
                if(i>m){

                    m = i;

                }

                if(i<n){

                    n = i;

                }

            }

        }

        
        io.println(n);
        io.println(m);
        io.close();
              
    
    }

}

class Kattio extends PrintWriter {
    public Kattio(InputStream i) {
        super(new BufferedOutputStream(System.out));
        r = new BufferedReader(new InputStreamReader(i));
    }
    public Kattio(InputStream i, OutputStream o) {
        super(new BufferedOutputStream(o));
        r = new BufferedReader(new InputStreamReader(i));
    }

    public boolean hasMoreTokens() {
        return peekToken() != null;
    }

    public int getInt() {
        return Integer.parseInt(nextToken());
    }

    public double getDouble() {
        return Double.parseDouble(nextToken());
    }

    public long getLong() {
        return Long.parseLong(nextToken());
    }

    public String getWord() {
        return nextToken();
    }



    private BufferedReader r;
    private String line;
    private StringTokenizer st;
    private String token;

    private String peekToken() {
        if (token == null)
            try {
                while (st == null || !st.hasMoreTokens()) {
                    line = r.readLine();
                    if (line == null) return null;
                    st = new StringTokenizer(line);
                }
                token = st.nextToken();
            } catch (IOException e) { }
        return token;
    }

    private String nextToken() {
        String ans = peekToken();
        token = null;
        return ans;
    }
}