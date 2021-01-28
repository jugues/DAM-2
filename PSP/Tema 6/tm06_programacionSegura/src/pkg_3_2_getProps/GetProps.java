/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg_3_2_getProps;

/**
 *
 * @author profesor
 */
import java.lang.*;


import java.security.*;

class GetProps {

    public static void main(String[] args) {

        /* Test reading properties w & w/out security manager */
        String s;

        try {

            System.out.println("About to get os.name property value");
            s = System.getProperty("os.name", "not specified");
            System.out.println("  The name of your operating system is:\t\t" + s);


            System.out.println("About to get java.version property value");
            s = System.getProperty("java.version", "not specified");
            System.out.println("  The version of the JVM you are running is:\t\t" + s);


            System.out.println("About to get user.home property value");
// aquí saltará excepción	    
            s = System.getProperty("user.home", "not specified");
            System.out.println("  Your user home directory is:\t\t" + s);


            System.out.println("About to get java.home property value");
            s = System.getProperty("java.home", "not specified");
            System.out.println("  Your JRE installation directory is:\t\t" + s);

        } catch (Exception e) {

            System.err.println("Caught exception " + e.toString());

        }

    }

}
