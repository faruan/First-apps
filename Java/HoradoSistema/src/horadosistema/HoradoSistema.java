/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package horadosistema;

import java.awt.Dimension;
import java.awt.Toolkit;
import java.util.Date;
import java.util.Locale;

/**
 *
 * @author Filipe
 */
public class HoradoSistema {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Date relogio = new Date();
        Locale loc = Locale.getDefault();
        Toolkit tk = Toolkit.getDefaultToolkit();
        Dimension d = tk.getScreenSize();
        System.out.println("A hora do sistema é:");
        System.out.println(relogio.toString());
        System.out.print("Seu sistema está em ");
        System.out.println(loc.getDisplayLanguage());
        System.out.println("Sua tela tem resolução " + d.width + " x " 
                +d.height);
    }
    
}
