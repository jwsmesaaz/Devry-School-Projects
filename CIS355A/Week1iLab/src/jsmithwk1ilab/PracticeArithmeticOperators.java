/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package jsmithwk1ilab;
import javax.swing.*;
/******************************************************************************
 Program Name: PracticeArithmeticOperators.java
 Programmers Name: Jonathan Smith
 Program Description: This program separates one number into its individual digits
 *****************************************************************************/
public class PracticeArithmeticOperators {
    public static void main(String[] args){
    String secondNumber;       //first dstring entered by the user
    int intSecNum;
    int rem;
  

    secondNumber = JOptionPane.showInputDialog("Enter Radius");
    intSecNum = Integer.parseInt(secondNumber);

    for(char c :String.valueOf(secondNumber).toCharArray())
    {
            System.out.print(c + " ");
            /*
            JOptionPane.showMessageDialog(null,c + " ", "Area",
            JOptionPane.PLAIN_MESSAGE);
            */
    }

    }
}
