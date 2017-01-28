/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/*
 * Index2.java
 *
 * Created on Apr 12, 2011, 7:49:29 PM
 */

package jsmithwk6ilab;

/**
 *
 * @author Jon Smith
 */
public class Index2 extends javax.swing.JFrame {

    /** Creates new form Index2 */
    public Index2() {
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

        jScrollPane1 = new javax.swing.JScrollPane();
        txtInput = new javax.swing.JTextArea();
        jLabel1 = new javax.swing.JLabel();
        btnOccur = new javax.swing.JButton();
        jScrollPane2 = new javax.swing.JScrollPane();
        txtArea = new javax.swing.JTextArea();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        txtInput.setColumns(20);
        txtInput.setRows(5);
        jScrollPane1.setViewportView(txtInput);

        jLabel1.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel1.setText("Enter some text:");

        btnOccur.setText("Count Occurences of Each Letter");
        btnOccur.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnOccurActionPerformed(evt);
            }
        });

        txtArea.setColumns(20);
        txtArea.setRows(5);
        jScrollPane2.setViewportView(txtArea);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(jScrollPane2, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, 380, Short.MAX_VALUE)
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, 380, Short.MAX_VALUE)
                    .addComponent(jLabel1, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, 380, Short.MAX_VALUE)
                    .addComponent(btnOccur, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, 380, Short.MAX_VALUE))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel1)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(btnOccur)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jScrollPane2, javax.swing.GroupLayout.DEFAULT_SIZE, 430, Short.MAX_VALUE)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnOccurActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnOccurActionPerformed
        // TODO add your handling code here:
        txtArea.setText("");

        String strInput = txtInput.getText().trim().toLowerCase();

        txtArea.append("A: " + LetterCount("a", strInput) + "\n");
        txtArea.append("B: " + LetterCount("b", strInput) + "\n");
        txtArea.append("C: " + LetterCount("c", strInput) + "\n");
        txtArea.append("D: " + LetterCount("d", strInput) + "\n");
        txtArea.append("E: " + LetterCount("e", strInput) + "\n");
        txtArea.append("F: " + LetterCount("f", strInput) + "\n");
        txtArea.append("G: " + LetterCount("g", strInput) + "\n");
        txtArea.append("H: " + LetterCount("h", strInput) + "\n");
        txtArea.append("I: " + LetterCount("i", strInput) + "\n");
        txtArea.append("J: " + LetterCount("j", strInput) + "\n");
        txtArea.append("K: " + LetterCount("k", strInput) + "\n");
        txtArea.append("L: " + LetterCount("l", strInput) + "\n");
        txtArea.append("M: " + LetterCount("m", strInput) + "\n");
        txtArea.append("N: " + LetterCount("n", strInput) + "\n");
        txtArea.append("O: " + LetterCount("o", strInput) + "\n");
        txtArea.append("P: " + LetterCount("p", strInput) + "\n");
        txtArea.append("Q: " + LetterCount("q", strInput) + "\n");
        txtArea.append("R: " + LetterCount("r", strInput) + "\n");
        txtArea.append("S: " + LetterCount("s", strInput) + "\n");
        txtArea.append("T: " + LetterCount("t", strInput) + "\n");
        txtArea.append("U: " + LetterCount("u", strInput) + "\n");
        txtArea.append("V: " + LetterCount("v", strInput) + "\n");
        txtArea.append("W: " + LetterCount("w", strInput) + "\n");
        txtArea.append("X: " + LetterCount("x", strInput) + "\n");
        txtArea.append("Y: " + LetterCount("y", strInput) + "\n");
        txtArea.append("Z: " + LetterCount("z", strInput));
    }//GEN-LAST:event_btnOccurActionPerformed

    /**
    * @param args the command line arguments
    */
    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Index2().setVisible(true);
            }
        });
    }
    public int LetterCount(String strLetter, String strInput)
    {
        int x = 0;
        int y = 0;
        String strInput1 = strInput;

        for (int i = 0; i < strInput.length(); i++)
            {

                if(strInput1.toLowerCase().substring(y).startsWith(strLetter))
                {
                    x++;
                    y++;
                    strInput1 = strInput;
                }
                else
                {
                    y++;
                    strInput1 = strInput;
                }
            }

        return x;
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnOccur;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JTextArea txtArea;
    private javax.swing.JTextArea txtInput;
    // End of variables declaration//GEN-END:variables

}
