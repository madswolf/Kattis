import java.util.StringTokenizer;
import java.io.BufferedReader;
import java.io.BufferedOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.io.OutputStream;
import java.util.HashMap;

public class Cetvrta{
    
    public static void main(String[] args){
        
        Kattio io = new Kattio(System.in);
        int x1 = io.getInt();
        int y1 = io.getInt();
        
        int x2 = io.getInt();
        int y2 = io.getInt();

        int x3 = io.getInt();
        int y3 = io.getInt();

        int xToFind = x1;
        int yToFind = y1;
        
        if(x1==x2){
            xToFind = x3;
        }
            
        if(x2==x3){
            xToFind = x1;
        }

        if(x1==x3){
            xToFind = x2;
        }
           
        if(y1==y2){
            yToFind = y3;
        }
            
        if(y2==y3){
            yToFind = y1;
        }

        if(y1==y3){
            yToFind = y2;
        }

    io.println(xToFind + " " + yToFind);
    
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