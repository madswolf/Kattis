import java.util.StringTokenizer;
import java.io.BufferedReader;
import java.io.BufferedOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.io.OutputStream;
import java.util.HashSet;

public class Kemija{
	
	public static void main(String[] args){
		
        Kattio io = new Kattio(System.in);
        String sentenceDecoded = "";

        while(io.hasMoreTokens()){
            String wordToDecode = io.getWord();
            String wordDecoded = "";
            for(int i=0;i<wordToDecode.length();i++){

                char checkVowel = wordToDecode.charAt(i);

                if(checkVowel=='a'||checkVowel=='e'||checkVowel=='i'||checkVowel=='o'||checkVowel=='u'){
                    i++;
                    i++;
                }

                wordDecoded += String.valueOf(checkVowel);

            }
            sentenceDecoded += wordDecoded +" ";
        }
        
        io.println(sentenceDecoded.trim());
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