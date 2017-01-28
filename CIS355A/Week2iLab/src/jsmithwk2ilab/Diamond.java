/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package jsmithwk2ilab;
import javax.swing.*;
/**
 *
 * @author Jon Smith
 */
public class Diamond {
    public static void main(String[] args)
    {
        //declare variable
        String strInput;
        int intInput;
        boolean boolOdd=false;

        //Make sure the number is odd and get user input
        while(boolOdd==false)
        {
            strInput = JOptionPane.showInputDialog(null, "Please enter an odd number");
            intInput = Integer.parseInt(strInput);

            if(intInput % 2==0)
            {
                boolOdd = false;
                JOptionPane.showMessageDialog(null, "Number must be Odd");
            }
            else
            {
                boolOdd = true;
                diamondOdAsterisks(strInput);
            }
        }


    }
    public static void diamondOdAsterisks(String strInput)
    {
        int intInput = Integer.parseInt(strInput);

        //Prints Top lines
        for(int i = 0; i < intInput/2 ; i++)
        {
            for(int y = 0; y < intInput/2-i;y++)
            {
                System.out.print(" ");
            }
            for(int x = 0 ; x < i * 2 + 1 ; x++)
            {
                System.out.print("*");
            }
            System.out.println();
        }

        //prints Middle Line
        for(int i = 0; i < intInput; i++)
        {
           System.out.print("*"); 
        }
        System.out.println();
        
        //prints Bottom Lines
        for(int i = intInput/2-1; i>=0; i--)
        {
            for(int y =0; y<intInput/2-i;y++)
            {
                System.out.print(" ");
            }
            for(int x = 0; x < i*2+1; x++)
            {
                System.out.print("*");
            }
            System.out.println();
        }

    }
}
