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
public class Palindrome {
public static void main(String[] args)
    {
       String strInput;
       boolean boolPalindrome;

       strInput = retrieveInput();
       boolPalindrome = check(strInput);
       Display(boolPalindrome);
    }
    public static String retrieveInput()
    {
        //Declares Variables
        String strInput = null;
        int intInput;
        boolean boolFive = false;

        while(boolFive==false)
        {
        //Get Input from User
        strInput = JOptionPane.showInputDialog(null, "Enter a Five(5) digit Number");

        //Converts string to int
        intInput = Integer.parseInt(strInput);

        //Makes sure the user entered a five digit number
            if(intInput>99999)
            {
                JOptionPane.showMessageDialog(null, "Invalid Number please enter a Five digit number");
            }
            else
            {
                boolFive=true;
                return strInput;
            }
        }

        return strInput;
    }
    public static boolean check(String strInput)
    {
        //Declares Variables
        boolean boolPalindrome;
        int num;
        int num2;
        int rev = 0;
        
        //Converts strInput into Integer
        num = Integer.parseInt(strInput);
        num2 = num;

        //Reverses number
        for(int x=0; x<=num; x++)
        {
            int r=num%10;
            num=num/10;
            rev=rev*10+r;
            x=0;
        }

        //Checks to see if number is a Palindrome
        if(num2==rev)
        {
            boolPalindrome = true;
        }
        else
        {
            boolPalindrome = false;
        }

        //Returns if it is a Palindrome or not
        return boolPalindrome;
    }
    public static void Display(boolean boolPalindrome)
    {
        if(boolPalindrome==true)
        {
            JOptionPane.showMessageDialog(null, "Number is a Palindrome");
        }
        else
        {
            JOptionPane.showMessageDialog(null, "Number is not a Palindrome");
        }
    }
}
