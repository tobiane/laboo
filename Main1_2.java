import java.awt.*;
        import javax.swing.*;

public class Main1_2 extends JPanel {
    int yPosition = 20;

    public Main1_2() {
    }

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        // Dibuja el asterisco en las coordenadas especificadas
        g.clearRect(1, 1, 300, 300);
        g.drawString("*", 100, yPosition);
    }

    public static void main(String[] args) {
        // Crea una nueva ventana
        JFrame frame = new JFrame("Asterisco en Pantalla");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        // Crea un panel personalizado para dibujar el asterisco
        Main1_2 panel = new Main1_2();

        frame.add(panel);
        frame.setSize(300, 300);
        frame.setVisible(true);

        // Utiliza un bucle for para hacer bajar el asterisco
        for (int i = 0; i < 200; i++) {
            try {
                Thread.sleep(500); // Pausa de 50 milisegundos
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
            // Actualiza la posición del asterisco
            panel.yPosition += 1; // Incrementa la posición Y para hacerlo bajar
            panel.repaint(); // Vuelve a dibujar el panel
        }
    }
}