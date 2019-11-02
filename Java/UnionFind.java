import java.util.StringTokenizer;
import java.io.BufferedReader;
import java.io.BufferedOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.io.OutputStream;

public class UnionFind{

    public static void main(String[] args)throws Exception{

        Kattio io = new Kattio(System.in);
        int n = io.getInt();
        int m = io.getInt();

        UF uf = new UF(n);
        for(int i=0;i<m;i++){
            if("?".equals(io.getWord())){
                if(uf.connected(io.getInt(),io.getInt())){
                    io.println("yes");
                } else {
                    io.println("no");
                }
            } else {
                uf.union(io.getInt(),io.getInt());
            }
        }
        io.close();
    }
}
class UF{
    
    private int[] id;
    private int[] depth;
    private int count;
    
    public UF(int N){

        count = N;

        id = new int[N];
        for(int i=0;i<N;i++){
            id[i] = i;
        }

        depth = new int[N];
        for(int i=0;i<N;i++){
            depth[i] = 1;
        }

    }

    public int count(){
        return count;
    }

    public int find(int p){
        while(!(p == id[p])){
            id[p] = id[id[p]];
            p = id[p];
        }
        return p;
    }

    public boolean connected(int p, int q){
        return find(p) == find(q);
        
    }

    public void union(int p, int q){
        int rootP = find(p);
        int rootQ = find(q);

        if(rootP == rootQ) return;

        if(depth[rootP] < depth[rootQ]){
            id[rootP] = rootQ;
            depth[rootQ] += depth[rootP];
        } else{
            id[rootQ] = rootP;
            depth[rootP] += depth[rootQ];
        }

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