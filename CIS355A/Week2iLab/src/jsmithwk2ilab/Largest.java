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
public class Largest {
    public static void main(String[] args)
    {
        int[] intNumber = new int[10];
        int intLargest = 0;

        for(int x=0; x<intNumber.length; x++)
        {
            intNumber[x] = Integer.parseInt(JOptionPane.showInputDialog(null, "Input Number " + (x+1)));
            if(intNumber[x] > intLargest)
            {
                intLargest = intNumber[x];
            }
            else
            {

            }
        }
        JOptionPane.showMessageDialog(null, "Largest number is: " + intLargest);
    }
}
