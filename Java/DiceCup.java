import java.util.StringTokenizer;
import java.io.BufferedReader;
import java.io.BufferedOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.io.OutputStream;

public class DiceCup{
    
    public static void main(String[] args){
        
        Kattio io = new Kattio(System.in);
        int dice1 = io.getInt();    
        int dice2 = io.getInt();

        int[] combinations = new int[dice1+dice2+2];
        int[] mostLikelyCombinations = new int[dice1+dice2+2];
        int countOfMostLikely = 1;

        mostLikelyCombinations[0] = 2;

        for(int i = 1;i <= dice1 ; i++){

            for(int j = 1;j <= dice2 ;j++){

                combinations[i+j]++;

                if(combinations[i+j]>combinations[mostLikelyCombinations[0]]){

                    mostLikelyCombinations = new int[dice1+dice2];
                    mostLikelyCombinations[0] = i+j;
                    countOfMostLikely = 1;

                }else if(combinations[i+j]==combinations[mostLikelyCombinations[0]]){
                    mostLikelyCombinations[countOfMostLikely] = i + j;
                    countOfMostLikely++;
                }
            }
        }

        for(int i=0;i<countOfMostLikely;i++){
            io.println(mostLikelyCombinations[i]);
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