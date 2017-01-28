/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package jsmithwk1ilab;
import javax.swing.*;
/******************************************************************************
 Program Name: Circle.java
 Programmers Name: Jonathan Smith
 Program Description: This program will calculate the area, circumference and diameter of a circle
 *****************************************************************************/
public class Circle {
    public static void main(String[] args){
    String firstNumber;     //first dstring entered by the user
    double dblRadius;          //converted user for Radius
    double dblDiameter;        //Finds the Diameter from the Radius
    double dblCircum;          //Finds the Circumference from the Radius
    double dblArea;            //Finds the Area from the Radius
    //read in first number as a string
    firstNumber = JOptionPane.showInputDialog("Enter Radius");
    //Converts Number to an integer
    dblRadius =  Double.parseDouble(firstNumber);
    //figures out the Diameter
    dblDiameter = 2*dblRadius;
    //Figures out the Circumference
    dblCircum = 2*Math.PI*dblRadius;
    //Figures out the Area
    dblArea = Math.PI*dblRadius*dblRadius;
    //display the results
    JOptionPane.showMessageDialog(null,"" + dblDiameter, "Diameter",
            JOptionPane.PLAIN_MESSAGE);
    JOptionPane.showMessageDialog(null,"" + dblCircum, "Circumference",
            JOptionPane.PLAIN_MESSAGE);
    JOptionPane.showMessageDialog(null,"" + dblArea, "Area",
            JOptionPane.PLAIN_MESSAGE);
    System.exit(0);         //terminate the application
    }
}
