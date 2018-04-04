
package pkg180403_actividad.enumerator.iterator;
import java.util.Enumeration;
import java.util.*;

public class Cliente {

    public static void main(String[] args) {
        String a="a";
        String b="b";
        String c="c";
        Vector<String> v = new Vector<String>();
        v.add(a);
        v.add(b);
        v.add(c);
       
        Enumeration<String> es = v.elements();
  
        
        adaptador enumerationtoIterator = new adaptador(es); 
        enumerationtoIterator.hasNext();
        enumerationtoIterator.next();
        enumerationtoIterator.remove();
      
    }
    
}


