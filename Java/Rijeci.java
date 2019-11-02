import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.HashMap;
import java.util.Map;

public class Rijeci {
    public static void main(String[] args) throws Exception {
        BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
        int caseCount = Integer.parseInt(in.readLine());
        Map<Character,Integer> map = initiateMap();
        String output = "";

        for(int i = 1 ; i <= caseCount ; i++){
            output += "Case #" + i + ": "; 
            for(char character : in.readLine().toCharArray()){
                output += map.get(character);        
            }
        }
    }

    public static Map<Character, Integer> initiateMap(){
        Map<Character,Integer> map = new HashMap<>();
        map.put('a',2);
        map.put('b',22);
        map.put('c',222);
        map.put('d',3);
        map.put('e',33);
        map.put('f',333);
        map.put('g',4);
        map.put('h',44);
        map.put('i',444);
        map.put('j',5);
        map.put('k',55);
        map.put('l',555);
        map.put('m',6);
        map.put('n',66);
        map.put('o',666);
        map.put('p',7);
        map.put('q',77);
        map.put('r',777);
        map.put('s',7777);
        map.put('t',8);
        map.put('u',88);
        map.put('v',888);
        map.put('w',9);
        map.put('x',99);
        map.put('y',999);
        map.put('z',9999);
        map.put(' ',0);
        return map;
    }
}