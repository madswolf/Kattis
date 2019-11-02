import java.util.StringTokenizer;
import java.io.BufferedReader;
import java.io.BufferedOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.io.OutputStream;

public class Datum{
    
    public static void main(String[] args){
        
       Kattio io = new Kattio(System.in);
       int day = io.getInt();   
       int month = io.getInt();

       switch (month){

        case 1://Jan 31 days
            day += 0;
            break;

        case 2://Feb 28 days
            day += 31;
            break;

        case 3://Mar 31
            day += 59;
            break;

        case 4://Apr 30 days
            day += 90;
            break;

        case 5://Maj 31 days
            day += 120;
            break;

        case 6://Jun 30 days 
            day += 151;
            break;

        case 7://Jul 31 days
            day += 181;
            break;

        case 8://Aug 31 days
            day += 212;
            break;

        case 9://sep 30
            day += 243;
            break;

        case 10://Oct 31
            day += 273;
            break;

        case 11://Nov 30 
            day += 304;
            break;
        case 12://Dec 31
            day += 334;
            break;
       }

    day = day%7;

    switch (day){

        case 0:
            io.println("Wednesday");
            break;
       

        case 1:
            io.println("Thursday");
            break;

        case 2:
            io.println("Friday");
            break;

       case 3:
            io.println("Saturday");
            break;

        case 4:
            io.println("Sunday");
            break;

        case 5:
            io.println("Monday");
            break;

        case 6:
            io.println("Tuesday");
            break;

    }
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