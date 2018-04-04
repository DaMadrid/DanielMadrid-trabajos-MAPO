
package pkg180403_actividad.enumerator.iterator;
import java.util.Enumeration;
import java.util.*;

public class adaptador implements Iterator  {
    Enumeration enumerate;
    
    public adaptador(Enumeration numero)
    {
    this.enumerate=numero;
    }
   
    @Override
    public boolean hasNext() {
    return  enumerate.hasMoreElements();
        
    }

    @Override
    public Object next() {
      return  enumerate.nextElement();
   }

    @Override
    public void remove() 
    {
        try {

        } catch (Exception name) {
                
        }
      
      
    }
    
}
