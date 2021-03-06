/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/*
 * iLabAssignment.java
 *
 * Created on Apr 12, 2011, 8:22:11 PM
 */

package cis355wk7inclass;

import java.util.Random;
/**
 *
 * @author Jon Smith
 */
public class iLabAssignment extends javax.swing.JFrame {

    /** Creates new form iLabAssignment */
    public iLabAssignment() {
        initComponents();
    }

    /** This method is called from within the constructor to
     * initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is
     * always regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel1 = new javax.swing.JLabel();
        jScrollPane1 = new javax.swing.JScrollPane();
        txtAssignment = new javax.swing.JTextArea();
        jLabel2 = new javax.swing.JLabel();
        jScrollPane2 = new javax.swing.JScrollPane();
        txtName = new javax.swing.JTextArea();
        jButton1 = new javax.swing.JButton();
        btnRun = new javax.swing.JButton();
        txtTest = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Presentation Schedule for Week7: Random Generator");

        jLabel1.setText("Assignment:");

        txtAssignment.setColumns(20);
        txtAssignment.setRows(5);
        txtAssignment.setText("Week 3\nWeek 4\nWeek 5\nWeek 6");
        jScrollPane1.setViewportView(txtAssignment);

        jLabel2.setText("Student Name:");

        txtName.setColumns(20);
        txtName.setRows(5);
        txtName.setText("Carter, Gregory\nCovert, David\nMcgill, Brenton\nMerjil, Brandon\nRose, Kyle\nSmith, Jonathan\nSt. Clair, Joon\nWheeler, Elliott");
        jScrollPane2.setViewportView(txtName);

        jButton1.setText("Exit");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        btnRun.setText("Run Assignment");
        btnRun.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnRunActionPerformed(evt);
            }
        });

        txtTest.setText("jLabel3");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(btnRun, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(jScrollPane1)
                            .addComponent(jLabel1))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(jLabel2)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 211, Short.MAX_VALUE)
                                .addComponent(jButton1))
                            .addComponent(jScrollPane2, javax.swing.GroupLayout.DEFAULT_SIZE, 334, Short.MAX_VALUE)))
                    .addComponent(txtTest))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(jLabel2)
                    .addComponent(jButton1))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(btnRun))
                    .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 156, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addComponent(txtTest)
                .addGap(72, 72, 72))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        // TODO add your handling code here:
        System.exit(0);
    }//GEN-LAST:event_jButton1ActionPerformed

    private void btnRunActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnRunActionPerformed
        // TODO add your handling code here:
        txtName.setText("");
        int count = 0;
        int num;
        int wk3 = 0;
        int wk4 = 0;
        int wk5 = 0;
        int wk6 = 0;
        String[] strStudents = {"Carter, Gregory", "Covert, David", "Mcgill, Brenton", "Merjil, Brandon",
                                "Rose, Kyle", "Smith, Jonathan", "St. Clair, Joon", "Wheeler, Elliott"};
        String[] strAssignment = new String[8];

        
        while(count < 8)
        {   
                num = RandomNumber();

                if(num == 1 && wk3 < 2)
                {
                    strAssignment[count] = "Week 3";
                    count++;
                    wk3++;
                }
                else if(num == 2 && wk4 < 2)
                {
                    strAssignment[count] = "Week 4";
                    count++;
                    wk4++;
                }
                else if(num == 3 && wk5 < 2)
                {
                    strAssignment[count] = "Week 5";
                    count++;
                    wk5++;
                }
                else if(num == 4 && wk6 < 2)
                {
                    strAssignment[count] = "Week 6";
                    count++;
                    wk6++;
                }
        }
               

        for(int i=0; i<strStudents.length;i++)
        {
            txtName.append(strStudents[i] + ": " + strAssignment[i] + "\n");
        }


    }//GEN-LAST:event_btnRunActionPerformed

    /**
    * @param args the command line arguments
    */
    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new iLabAssignment().setVisible(true);
            }
        });
    }
    public int RandomNumber()
    {
        Random rNumber = new Random();
        int r = rNumber.nextInt(5);

        while(r<1)
        {
            r = rNumber.nextInt(4);
        }
        if(r>4)
        {
            r = RandomNumber();
        }

        return r;
    }
    
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnRun;
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JTextArea txtAssignment;
    private javax.swing.JTextArea txtName;
    private javax.swing.JLabel txtTest;
    // End of variables declaration//GEN-END:variables

}
